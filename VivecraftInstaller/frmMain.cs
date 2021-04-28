using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Security.Policy;
using System.IO;
using System.Threading.Tasks.Sources;
using System.Xml.Serialization;

namespace VivecraftInstaller
{

    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void chkProfileName_CheckedChanged(object sender, EventArgs e)
        {
            txtProfileName.Enabled = chkProfileName.Checked;
        }

        private void chkModDir_CheckedChanged(object sender, EventArgs e)
        {
            txtModDir.Visible = chkModDir.Checked;
            btnModDir.Visible = chkModDir.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pnlProfile.Visible = chkProfile.Checked;
        }

        private void chkForge_CheckedChanged(object sender, EventArgs e)
        {
            pnlForge.Visible = chkForge.Checked;
        }

        private void chkPath_CheckedChanged(object sender, EventArgs e)
        {
            pnlPath.Visible = chkPath.Checked;
        }

        private void chkadvanced_CheckedChanged(object sender, EventArgs e)
        {
            pnlAdvanced.Visible = chkadvanced.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getVersions()
        {
            try
            {
                string vers = Util.getWebRequestwithTimeout(Config.versionsUrl, 5);
                JsonDocument doc = JsonDocument.Parse(vers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private Dictionary<string, object> getCfg(string url)
        {
            return parseCfg(Util.getWebRequestwithTimeout(url, 10));
        }

        private Dictionary<string, object> parseCfg(string cfg)
        {
            string[] lines = cfg.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, object> ret = new Dictionary<string, object>();
            foreach (var l in lines)
            {
                var pts = l.Split('=');
                if (pts.Length != 2) continue;
                var val = pts[1].Trim();
                bool res;
                if (bool.TryParse(val, out res))
                {
                    ret[pts[0].Trim()] = res;
                }
                else
                {
                    ret[pts[0].Trim()] = pts[1].Trim().Replace("\"", "");
                }
            }
            return ret;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getVersions();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Config.targetDir = txtTarget.Text;
            var frm = new frmInstalling(this);
            frm.Show();
            frm.run();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
