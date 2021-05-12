using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Deployment.Application;

namespace VivecraftInstaller {
    public partial class frmMain : Form {

        public frmMain() {
            InitializeComponent();
        }

        private void chkProfileName_CheckedChanged(object sender, EventArgs e) {
            txtProfileName.Enabled = chkProfileName.Checked;
        }

        private void chkModDir_CheckedChanged(object sender, EventArgs e) {
            txtModDir.Visible = chkModDir.Checked;
            btnModDir.Visible = chkModDir.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            grpProfile.Visible = chkProfile.Checked;
        }

        private void chkForge_CheckedChanged(object sender, EventArgs e) {
            grpForge.Visible = chkForge.Checked;
        }

        private void chkPath_CheckedChanged(object sender, EventArgs e) {
            grpPath.Visible = chkPath.Checked;
        }

        private void chkadvanced_CheckedChanged(object sender, EventArgs e) {
            grpAdvanced.Visible = chkadvanced.Checked;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private string getVersions() {
            string vers = null;
            try {
                vers = Util.getWebRequestwithTimeout(Global.versionsUrl, 5);
            } catch (Exception ex) {
                this.BeginInvoke((MethodInvoker)delegate {
                    MessageBox.Show(this, "Cannot download versions List!\n " + ex.Message);
                });

                try {
                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VivecraftInstaller.json.versions.json")) {
                        using (TextReader reader = new StreamReader(stream)) {
                            vers = reader.ReadToEnd();
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("Cannot extract versions List!\n " + ex.Message);
                }
            }
            return vers;
        }

        private Config getCfg(string url) {
            return parseCfg(Util.getWebRequestwithTimeout(url, 10));
        }

        private Config parseCfg(string cfg) {
            string[] lines = cfg.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, object> ret = new Dictionary<string, object>();
            foreach (var l in lines) {
                var pts = l.Split('=');
                if (pts.Length != 2) continue;
                var val = pts[1].Trim();
                bool res;
                if (bool.TryParse(val, out res)) {
                    ret[pts[0].Trim()] = res;
                } else {
                    ret[pts[0].Trim()] = pts[1].Trim().Replace("\"", "");
                }
            }
            return new Config(ret);
        }

        private void Form1_Load(object sender, EventArgs e) {
            invis();
            this.Text = "Vivecraft Installer " + Assembly.GetExecutingAssembly().GetName().Version;
            System.Threading.ThreadPool.QueueUserWorkItem(startup);
        }

        private void startup(object state) {
            updateCheck();
            var json = getVersions();
            if (json == null) {
                MessageBox.Show("Fatal: Cannot get versions list!");
                Application.Exit();
            } else {
                VersionList versionlist = Newtonsoft.Json.JsonConvert.DeserializeObject<VersionList>(json);

                foreach (Version ver in versionlist.versions) { //download and parse the configs
                    //TODO: do this as needed with a cache.
                    try {
                        ver.configVR = getCfg(ver.vrcfg);
                    } catch (Exception) {
                    }

                    try {
                        ver.configNONVR = getCfg(ver.nonvrcfg);
                    } catch (Exception) {
                    }
                }


                this.BeginInvoke((MethodInvoker)delegate {
                    this.Cursor = Cursors.Default;
                    populateVersions(versionlist);
                });
            }
        }

        private VersionList versionlist;
        private void populateVersions(VersionList list) {
            this.versionlist = list;
            cmbVersion.Items.Clear();
            cmbVersion.Items.AddRange(list.versions);
            if (cmbVersion.Items.Count > 0) cmbVersion.SelectedIndex = 0;
        }

        private void updateCheck() {

        }

        private void button1_Click(object sender, EventArgs e) {
            var version = ((Version)cmbVersion.SelectedItem);
            var config = version.configVR;

            if (optNonVR.Checked) {
                config = ((Version)cmbVersion.SelectedItem).configNONVR;
                config.isNonVR = true;
            }

            Global.isForge = chkForge.Checked && chkForge.Visible;
            Global.isKatVR = chkadvanced.Checked && chkKatVR.Checked && chkKatVR.Visible;
            Global.isKiosk = chkKiosk.Checked && chkKiosk.Checked && chkKiosk.Visible;
            Global.forgeVersion = txtForgeVersion.Text;
            Global.targetDir = txtTarget.Text;
            Global.createProfile = chkProfile.Checked;
            Global.profileName = txtProfileName.Text;
            Global.customGameDir = chkModDir.Checked;
            Global.gameDir = txtModDir.Text;
            Global.zgc = false;
            Global.xms = int.Parse((string)cmbRAM.SelectedItem);
            Global.xmx = int.Parse((string)cmbRAM.SelectedItem);

            if (chkZGC.Checked && config.ALLOW_ZGC_INSTALL) {
                Global.zgc = true;
                Global.gcOpts = "-XX:+UnlockExperimentalVMOptions -XX:+UseZGC";
            }

            var frm = new frmInstalling(this, config, version.releases);
            frm.Show();
            frm.run();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void invis() {
            foreach (Control control in tableLayoutPanel1.Controls) {
                if (control != pnlVersion && control != pnlButtons)
                    control.Visible = false;
            }
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e) {
            Version selection = (Version)cmbVersion.SelectedItem;
            Config cfg = null;

            if (selection == null) {
                invis();
            } else {
                cfg = selection.configVR;
                if (optNonVR.Checked)
                    cfg = selection.configNONVR;

                if (cfg == null) {
                    invis();
                    lblVersionDetails.Text = "ERROR";
                } else {
                    pnlCustom.Visible = true;
                    pnlProfileOpt.Visible = true;
                    pnlForgeOpt.Visible = cfg.ALLOW_FORGE_INSTALL; ;
                    pnlAdvanced.Visible = cfg.ALLOW_HRTF_INSTALL || cfg.ALLOW_KATVR_INSTALL || cfg.ALLOW_KIOSK_INSTALL || cfg.PROMPT_REMOVE_HRTF;
                    lblVersionDetails.Text = cfg.PROJECT_NAME + " " + cfg.VIVECRAFT_VERSION;
                    txtForgeVersion.Text = cfg.FORGE_VERSION;
                    chkForge.Checked = cfg.DEFAULT_FORGE_INSTALL;
                    txtProfileName.Text = !chkForge.Checked ? cfg.DEFAULT_PROFILE_NAME : cfg.DEFAULT_PROFILE_NAME_FORGE;
                    cmbRAM.SelectedIndex = !chkForge.Checked ? 1 : 3;
                    txtTarget.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
                    chkZGC.Visible = cfg.ALLOW_ZGC_INSTALL;
                }
            }
            btnInstall.Enabled = cfg != null;
        }


        private void checkBox7_CheckedChanged(object sender, EventArgs e) {
            txtForgeVersion.ReadOnly = !checkBox7.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(Global.HOMEPAGE_LINK);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(Global.DONATION_LINK);
        }

        private void optNonVR_CheckedChanged(object sender, EventArgs e) {
            cmbVersion_SelectedIndexChanged(this, null);
        }

        private void btnModDir_Click(object sender, EventArgs e) {
            var f = new FolderBrowserDialog();
            f.SelectedPath = "C:\\";
            if (f.ShowDialog(this) == DialogResult.OK) {
                txtModDir.Text = f.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            var f = new FolderBrowserDialog();
            f.SelectedPath = "C:\\";
            if (f.ShowDialog(this) == DialogResult.OK) {
                txtTarget.Text = f.SelectedPath;
            }
        }

        private void chkZGC_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
