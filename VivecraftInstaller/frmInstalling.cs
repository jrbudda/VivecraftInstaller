using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivecraftInstaller
{
    public partial class frmInstalling : Form
    {
        private frmMain parent;
        public frmInstalling(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmInstalling_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (thread != null)
                {
                    thread.Abort();
                }
            }
            catch (Exception)
            {
            }
            parent.Show();
        }

        public void log(string msg)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                textBox1.AppendText(Environment.NewLine + " " + msg);
            });
        }

        Thread thread;
        public void run()
        {
            thread = new Thread(task);
            thread.IsBackground = true;
            thread.Start();
        }

        private void prog(int increment)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                progress.Increment(increment);
            });
        }

        private void task()
        {

            //Optifine
            log("Downloading Optifine...");
            string dest = Path.Combine(Config.targetDir, Config.OF_LIB_PATH + Config.OF_FILE_NAME + "_LIB");
            if (Config.isMultiMC)
                dest = Path.Combine(Config.mmcinst, "libraries");
            DownloadOptiFine(dest);
            //

            prog(5);

            //Library
            log("Downloading Vivecraft...");
            string dest = Path.Combine(Config.targetDir, Config.OF_LIB_PATH + Config.OF_FILE_NAME + "_LIB");
            if (Config.isMultiMC)
                dest = Path.Combine(Config.mmcinst, "libraries");
            DownloadOptiFine(dest);
            //

            prog(5);

            //Profile
            if (Config.createProfile)
            {
                log("Creating Profile");
                //createProfile();
            }
            prog(5);
            //

        }
        private string checkMMC(string targetDir)
        {
            DirectoryInfo di = new DirectoryInfo(targetDir);
            //check for multimc
            if (di.Exists)
                foreach (var f in di.GetFiles())
                {
                    if (f.Name.ToLower().Equals("multimc.exe") || (f.Name.ToLower().Equals("multimc")) || f.Name.ToLower().Equals("multimc.cfg"))
                    {
                        var ilist = new List<string>();
                        DirectoryInfo insts = new DirectoryInfo(Path.Combine(targetDir, "instances"));
                        if (!insts.Exists)
                        {
                            MessageBox.Show(this, "MultiMC files were detected in the install path, but the instances directory is missing, so we're going to assume it isn't MultiMC.\nIf it actually is MultiMC, set up an instance for Vivecraft first, then run this installer again.", "MultiMC Detection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        foreach (DirectoryInfo inst in insts.GetDirectories())
                        {
                            if (!inst.Name.StartsWith("_"))
                                ilist.Add(inst.Name);
                        }
                        var selector = new DropDownSelector(ilist, "Select MultiMC Instance");
                        selector.Text = "MultiMC Detected";

                        if (selector.ShowDialog() == DialogResult.OK && selector.selection != null)
                        {
                            return selector.selection;
                        }
                        break; // don't ask multiple times
                    }

                }
            return null;
        }

        private bool DownloadOptiFine(string destination)
        {
            try
            {

                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }

                string filename = Path.Combine(destination, "OptiFine-" + Config.OF_FILE_NAME + "_LIB.jar");
                var fo = new FileInfo(filename);

                //checks md5 and downloads if needed.
                var success = downloadFile(Config.OF_URL, fo, Config.OF_MD5);

                return true;
            }
            catch (Exception e)
            {
                log(" Error: " + e.Message);
            }
            return false;
        }

        private bool downloadFile(string surl, FileInfo fo, string md5)
        {

            if (fo.Exists)
            {
                if (md5 != null && Util.checkMD5(fo, md5))
                {
                    log(fo.Name + " already exists, skipping download");
                    return true;
                }
                else
                {
                    log(fo.Name + " already exists, bad hash, deleting");
                    fo.Delete();
                }
            }

            var bytes = Util.getWebBinarywithTimeout(surl, 10);
            using (var fs = fo.OpenWrite())
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            var ok = md5 == null || Util.checkMD5(fo, md5);

            if (!ok)
            {
                log(fo.Name + " Downloaded but bad hash, deleting");
                fo.Delete();
            }

            return ok;

        }

        private bool ExtractVersion()
        {
            if (Config.JAR_ID == null) return false;
            string mod = "";
            //InputStream version_json;
            if (Config.isMultiMC)
            {
                string filename = "version-multimc.json";

                if (Config.isForge)
                    filename = "version-multimc-forge.json";
                //version_json = Installer.class.getResourceAsStream(filename);
            }

            else if (Config.isForge)
            {
                string filename;

                filename = "version-forge.json";
                mod = "-forge";

                //					version_json = new FilterInputStream(Installer.class.getResourceAsStream(filename) ) {
                //					version_json = new FilterInputStream(Installer.class.getResourceAsStream(filename) ) {
                //						public int read(byte[] buff) throws IOException
                //    {
                //							int ret = in.read(buff);
                //							if( ret > 0 ) {
                //            string s = new string(buff, 0, ret, "UTF-8");
                //            if (optCustomForgeVersion.isSelected())
                //                s = s.replace(ORIG_FORGE_VERSION, FORGE_VERSION);
                //            ret = s.length();
                //            System.arraycopy(s.getBytes("UTF-8"), 0, buff, 0, ret);
                //        }
                //							return ret;
                //    }
                //};
            }
            else
            {
                string filename;
                if (Config.isShadersMod)
                {
                    filename = "version-shadersmod.json";
                    mod = "-shadersmod";
                }
                else
                {
                    filename = "version.json";
                }
                //version_json = Installer.class.getResourceAsStream(filename);
            }

            Config.JAR_ID += mod;
            //InputStream version_jar = Installer.class.getResourceAsStream("version.jar");
            //TODO download or extract jar and jsons(s)
            object version_jar = null;
            object version_json = null;

            if (version_jar != null && version_json != null)
            {
                try
                {
                    string ver_dir = null;
                    if (Config.isMultiMC)
                    {
                        ver_dir = Path.Combine(Config.mmcinst, "patches");
                        Config.JAR_ID = "vivecraft";
                    }
                    else
                        ver_dir = Path.Combine(Config.targetDir, "versions", Config.JAR_ID);

                    if (!Directory.Exists(ver_dir))
                    {
                        Directory.CreateDirectory(ver_dir);
                    }

                    //string ver_json_file = Path.Combine(ver_dir, jar_id + ".json");
                    //FileOutputStream ver_json = new FileOutputStream(ver_json_file);
                    //int d;
                    //byte data[] = new byte[40960];

                    // Extract json
                    //while ((d = version_json.read(data)) != -1)
                    //{
                    //    ver_json.write(data, 0, d);
                    //}
                    //ver_json.close();

                    //modify json args if needed
                    try
                    {
                        int jsonIndentSpaces = 2;
                        string fileJson = ""; //ver_json_file;

                        JObject root = null;

                        using (var reader = new JsonTextReader(File.OpenText(fileJson)))
                        {
                            root = (JObject)JToken.ReadFrom(reader);
                        }

                        string args = (string)root["minecraftArguments"];

                        if (args != null)
                        {
                            if (Config.isKatVR) args += " --katvr";
                            if (Config.isKiosk) args += " --kiosk";
                            root.Add("minecraftArguments", args);
                        }

                        if (Config.isMultiMC)
                            root.Remove("id");

                        /*if(isMultiMC && useForge.isSelected()) {
                            JSONArray tw = (JSONArray) root.get("+tweakers");
                            tw = new JSONArray();
                            tw.put("org.vivecraft.tweaker.MinecriftForgeTweaker");
                            tw.put("net.minecraftforge.fml.common.launcher.FMLTweaker");
                            tw.put("optifine.OptiFineForgeTweaker");
                            root.put("+tweakers", tw);
                        }*/

                        using (JsonTextWriter writer = new JsonTextWriter(File.CreateText(fileJson)))
                        {
                            root.WriteTo(writer);
                        }
                    }
                    catch (Exception e)
                    {
                        log(" Error: " + e.Message);
                    }

                    // Extract new lib
                    string lib_dir = Path.Combine(Config.targetDir, "libraries/com/mtbs3d/minecrift/", version);
                    if (Config.isMultiMC)
                        lib_dir = Path.Combine(Config.mmcinst, "libraries");

                    if (!Directory.Exists(lib_dir))
                    {
                        Directory.CreateDirectory(lib_dir);
                    }

                    string ver_file = Path.Combine(lib_dir, "minecrift-" + version + ".jar");

                    //FileOutputStream ver_jar = new FileOutputStream(ver_file);
                    //while ((d = version_jar.read(data)) != -1)
                    //{
                    //    ver_jar.write(data, 0, d);
                    //}
                    //ver_jar.close();

                    //return ver_json_file.exists() && ver_file.exists();
                }
                catch (Exception e)
                {
                    log(" Error: " + e.Message);
                }
            }
            return false;
        }

    }
}
