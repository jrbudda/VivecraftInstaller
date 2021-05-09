using ICSharpCode.SharpZipLib.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace VivecraftInstaller {
    public partial class frmInstalling : Form {
        private frmMain parent;
        private Config Config;
        private string releases;
        public frmInstalling(frmMain parent, Config selectedConfig, string releases) {
            InitializeComponent();
            this.parent = parent;
            this.Config = selectedConfig;
            this.releases = releases;
        }
        private void button1_Click(object sender, EventArgs e) {
            if (button1.Text == "Close")
                Application.Exit();
            else
                this.Close();
        }
        private void frmInstalling_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                if (thread != null) {
                    thread.Abort();
                }
            } catch (Exception) {
            }
            parent.Show();
        }

        public void log(string msg) {
            this.BeginInvoke((MethodInvoker)delegate {
                textBox1.AppendText(Environment.NewLine + " " + msg);
            });
        }

        Thread thread;
        public void run() {
            thread = new Thread(task);
            thread.IsBackground = true;
            thread.Start();
        }

        private void prog(int increment) {
            this.BeginInvoke((MethodInvoker)delegate {
                progress.Increment(increment);
            });
        }

        private void task() {
            log("Checking Compatibility...");

            //Check Java
            log("Checking Java...");
            var java = Util.getJava(Global.customJavaPath);
            log("Java Results: " + java);

            if (java == "") {
                log("System java not found");
                Global.customJavaPath = null;

                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Minecraft", "runtime");
                if (Directory.Exists(dir)) {
                    var runtimes = Directory.GetFiles(dir, "javaw.exe", SearchOption.AllDirectories);
                    foreach (string r in runtimes) {
                        //UMM..... pick one?
                        var fo = new FileInfo(r);
                        Global.customJavaPath = fo.DirectoryName;
                        log("Minecraft java found");
                        java = Util.getJava(Global.customJavaPath);
                    }
                }
            }

            if (Global.zgc) {
                int ver = Util.parseJavaVersion(java);
                if (ver < 14 && ver >= 15) {
                    log("ZGC is selected but a compatible Java was not found");
                    //TODO: more
                }
            }
            //

            prog(5);

            //Check System
            log("Checking GPU...");
            var gpus = Util.getGPU();
            var intel = false;
            log("GPU Results:");
            foreach (var gpu in gpus) {
                log("Found: " + gpu);
                if (gpu.ToLower().Contains("intel")) intel = true;
            }
            if (intel && gpus.Length == 1) {
                //nope
                log("Only found integrated graphics.");
                if (MessageBox.Show("Only found Intel Integrated Grpahics on this PC. \n" +
                       "Intel drivers do not support VR in OpenGL-based games like Minecraft.\n" +
                       "Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            } else if (intel && gpus.Length > 1) {
                //warn
                log("Multiple GPUs found.");
                MessageBox.Show(null, "This PC has multiple GPUs including Intel Integrated graphics. \n" +
                   "You must force Windows to run Java on the non-integrated GPU or Vivecraft will not render." +
                   "More information can be found on the Vivecraft website FAQ.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //

            prog(5);

            //Vivecraft

            log("Getting Archive URL...  " + releases);
            var api = Util.getWebRequestwithTimeout(this.releases + "/latest", 10);
            JObject apijson = JObject.Parse(api);
            JArray assets = (JArray)apijson["assets"];
            string dlurl = null;
            foreach (JObject asset in assets) {
                var url = (string)asset["browser_download_url"];
                if (Config.isNonVR && url.ToLower().Contains("nonvr")) {
                    dlurl = url;
                    break;
                }
                if (!Config.isNonVR && !url.ToLower().Contains("nonvr")) {
                    dlurl = url;
                    break;
                }
            }

            if (dlurl == null) {
                log("Error finding correct archive to download!");
                return;
            }

            log("Downloading Vivecraft " + Config.VIVECRAFT_VERSION + " from " + dlurl);
            prog(5);

            var jar = Util.getWebBinarywithTimeout(dlurl, 10);
            using (MemoryStream mem = new MemoryStream(jar)) {
                using (ICSharpCode.SharpZipLib.Zip.ZipFile archive = new ICSharpCode.SharpZipLib.Zip.ZipFile(mem)) {
                    log("Extracting Vivecraft Files...");
                    var ret = ExtractVersion(archive);
                    if (!ret) {
                        log("Something has gone wrong extracting the files!");
                        return;
                    }
                }
            }
            log("Sucess");

            prog(15);

            //Profile
            if (Global.createProfile) {
                log("Creating Profile...");
                updateLauncherJson();
                log("Sucess");
            } else {
                log("Skipping Profile Update");
            }
            prog(5);
            //

            if (Global.isForge && !Global.isMultiMC)
                if (!checkForge()) {
                    prog(5);
                    log("Selected Forge version not found.");
                    if (installForge()) {
                        log("Success");
                    } else {
                        log("Failed to install selected Forge version");
                    }
                    prog(5);
                } else {
                    log("Selected Forge version already installed.");
                }


            log("Installation Complete.");

            prog(500);

            this.BeginInvoke((MethodInvoker)delegate {
                button1.Text = "Close";
            });
        }
        private string checkMMC(string targetDir) {
            DirectoryInfo di = new DirectoryInfo(targetDir);
            //check for multimc
            if (di.Exists)
                foreach (var f in di.GetFiles()) {
                    if (f.Name.ToLower().Equals("multimc.exe") || (f.Name.ToLower().Equals("multimc")) || f.Name.ToLower().Equals("multimc.cfg")) {
                        var ilist = new List<string>();
                        DirectoryInfo insts = new DirectoryInfo(Path.Combine(targetDir, "instances"));
                        if (!insts.Exists) {
                            MessageBox.Show(this, "MultiMC files were detected in the install path, but the instances directory is missing, so we're going to assume it isn't MultiMC.\nIf it actually is MultiMC, set up an instance for Vivecraft first, then run this installer again.", "MultiMC Detection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        foreach (DirectoryInfo inst in insts.GetDirectories()) {
                            if (!inst.Name.StartsWith("_"))
                                ilist.Add(inst.Name);
                        }
                        var selector = new DropDownSelector(ilist, "Select MultiMC Instance");
                        selector.Text = "MultiMC Detected";

                        if (selector.ShowDialog() == DialogResult.OK && selector.selection != null) {
                            return selector.selection;
                        }
                        break; // don't ask multiple times
                    }

                }
            return null;
        }
        string version_id = null;
        private bool ExtractVersion(ICSharpCode.SharpZipLib.Zip.ZipFile archive) {
            string mod = "";
            string json_filename = null;
            if (Global.isMultiMC) {
                json_filename = "version-multimc.json";
                if (Global.isForge)
                    json_filename = "version-multimc-forge.json";
            } else if (Global.isForge) {
                json_filename = "version-forge.json";
                mod = "-forge";
            } else {
                if (Global.isShadersMod) {
                    json_filename = "version-shadersmod.json";
                    mod = "-shadersmod";
                } else {
                    json_filename = "version.json";
                }
            }

            if (json_filename == null) {
                log("Invalid Options!");
                return false;
            }

            ICSharpCode.SharpZipLib.Zip.ZipEntry version_jar = null;
            JObject version_json = null;

            foreach (ICSharpCode.SharpZipLib.Zip.ZipEntry entry in archive) {
                if (entry.Name.ToLower() == "version.jar") {
                    version_jar = entry;
                    continue;
                }
                if (entry.Name.ToLower() == "version") {

                    var txt = new StreamReader(archive.GetInputStream(entry)).ReadToEnd();
                    var pts = txt.Split(':');
                    version_id = pts[0];
                    continue;
                }
                if (entry.Name.ToLower() == json_filename) {
                    try {
                        var txt = new StreamReader(archive.GetInputStream(entry)).ReadToEnd();
                        version_json = JObject.Parse(txt);
                    } catch (Exception ex) {
                        log("Failed parsing version json! " + ex.Message);
                    }
                    continue;
                }
            }

            if (version_jar == null || version_json == null || version_id == null) {
                log("Invalid archive!");
                return false;
            }

            version_id += mod;

            //modify json args if needed
            try {
                string args = (string)version_json["minecraftArguments"];

                if (args != null) {
                    if (Global.isKatVR) args += " --katvr";
                    if (Global.isKiosk) args += " --kiosk";
                    version_json["minecraftArguments"] = args;
                }

                if (Global.isMultiMC)
                    version_json.Remove("id");

                JArray libs = (JArray)version_json["libraries"];
                //Since this installer does not download Optifine, inject the url into any existing json not yet updated.
                foreach (var lib in libs) {
                    if (lib["name"].ToString().Contains("optifine:OptiFine") && lib["url"] == null) {
                        lib["url"] = "http://vivecraft.org/jar/";
                        if (lib["MMC-hint"] != null)
                            lib["MMC-hint"].Parent.Remove();
                    }
                }

                /*if(isMultiMC && useForge.isSelected()) {
                    JSONArray tw = (JSONArray) root.get("+tweakers");
                    tw = new JSONArray();
                    tw.put("org.vivecraft.tweaker.MinecriftForgeTweaker");
                    tw.put("net.minecraftforge.fml.common.launcher.FMLTweaker");
                    tw.put("optifine.OptiFineForgeTweaker");
                    root.put("+tweakers", tw);
                }*/
            } catch (Exception e) {
                log("Error modifying version json! " + e.Message);
            }

            //write version json
            try {
                string ver_dir = null;
                if (Global.isMultiMC) {
                    ver_dir = Path.Combine(Global.mmcinst, "patches");
                    version_id = "vivecraft";
                } else
                    ver_dir = Path.Combine(Global.targetDir, "versions", version_id);

                if (!Directory.Exists(ver_dir))
                    Directory.CreateDirectory(ver_dir);
                string ver_json_file = Path.Combine(ver_dir, version_id + ".json");
                File.WriteAllText(ver_json_file, version_json.ToString(Formatting.Indented));
            } catch (Exception ex) {
                log("Failed writing version json! " + ex.Message);
            }

            //write lib jar
            try {
                string lib_dir = Path.Combine(Global.targetDir, "libraries", "com", "mtbs3d", "minecrift", Config.VIVECRAFT_VERSION);
                if (Global.isMultiMC)
                    lib_dir = Path.Combine(Global.mmcinst, "libraries");

                if (!Directory.Exists(lib_dir)) {
                    Directory.CreateDirectory(lib_dir);
                }

                string ver_file = Path.Combine(lib_dir, "minecrift-" + Config.VIVECRAFT_VERSION + ".jar");

                if (File.Exists(ver_file))
                    File.Delete(ver_file);

                using (var reader = archive.GetInputStream(version_jar)) {
                    using (var writer = File.OpenWrite(ver_file)) {
                        StreamUtils.Copy(reader, writer, new byte[2048]);
                    }
                }
                return true;
            } catch (Exception e) {
                log("Error writing library jar! " + e.Message);
            }

            return false;
        }

        private bool updateLauncherJson() {
            bool result = false;

            try {
                string fileJson = Path.Combine(Global.targetDir, "launcher_profiles.json");
                string json = File.ReadAllText(fileJson);
                JObject root = JObject.Parse(json);

                JObject profiles = (JObject)root["profiles"];
                JObject prof = null;

                try {
                    prof = (JObject)profiles[Global.profileName];
                } catch (Exception e) {
                    //this is normal if doesnt exist.
                }

                string dateFormat = "yyyy-MM-dd'T'HH:mm:ss.fffZ";

                if (prof == null) {
                    prof = new JObject();
                    prof["created"] = DateTime.Now.ToString(dateFormat);
                    profiles[Global.profileName] = prof;
                }

                prof["lastVersionId"] = version_id;
                prof["javaArgs"] = "-Xmx" + Global.xmx + "G -Xms" + Global.xms + "G " + Global.gcOpts;
                prof["name"] = Global.profileName;
                prof["icon"] = Global.ICON;
                prof["type"] = "custom";
                prof["lastUsed"] = DateTime.Now.ToString(dateFormat);

                if (Global.customGameDir && Global.gameDir.Trim() != "") {
                    String dir = Global.gameDir.Trim();
                    if (dir.EndsWith("\\mods")) dir = dir.Substring(0, dir.Length - 5);
                    if (dir.EndsWith("\\mods\\")) dir = dir.Substring(0, dir.Length - 6);
                    prof["gameDir"] = dir;
                } else {
                    prof.Remove("gameDir");
                }

                if (Global.zgc) {
                    String javaExe;
                    if (prof.ContainsKey("javaDir"))
                        javaExe = (string)prof["javaDir"];
                    else {
                        javaExe = "";
                    }
                    if (Global.isCustomJava) {
                        prof["javaDir"] = Global.customJavaPath;
                    }
                }


                File.WriteAllText(fileJson, root.ToString(Formatting.Indented));

                result = true;
            } catch (Exception e) {
                log("Error updating launcher profiles! " + e.Message);
            }

            return result;
        }

        public bool checkForge() {
            if (Directory.Exists(Global.targetDir)) {
                string ForgeDir = Path.Combine(Global.targetDir, "libraries", "net", "minecraftforge", "forge");
                if (!Directory.Exists(ForgeDir)) return false;
                var forgeVersions = Directory.GetDirectories(ForgeDir);
                if (forgeVersions != null && forgeVersions.Length > 0) {
                    // Check for the currently required forge
                    foreach (string forgeVersion in forgeVersions) {
                        if (forgeVersion.Contains(Config.FORGE_VERSION)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool installForge() {
            if (Global.customJavaPath == null) {
                if(MessageBox.Show(this, "The installer could not locate a java runtime, the Forge isntaller may not run. Continue?"
                    ,"No Java", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No){
                    return false;
                }
                Global.customJavaPath = "";
            }

            log("Downloading Forge " + Config.FULL_FORGE_VERSION + "");

            var dir = Path.GetTempPath();
            var file = Config.FORGE_FILE;
            var path = Path.Combine(dir, file);

            byte[] jar = null;
            try {
                jar = Util.getWebBinarywithTimeout(Config.FORGE_URL, 10);
            } catch (Exception ex) {
                log("Error downloading Forge " + ex.Message);
                return false;
            }

            try {
                if (File.Exists(path))
                    File.Delete(path);
            } catch (Exception ex) {
                log("Error downloading Forge " + ex.Message);
                return false;
            }


            try {
                using (var reader = new MemoryStream(jar)) {
                    using (var writer = File.OpenWrite(path)) {
                        StreamUtils.Copy(reader, writer, new byte[2048]);
                    }
                }
            } catch (Exception ex) {
                log("Error downloading Forge " + ex.Message);
                return false;
            }

            prog(5);
            log("Launching Forge Installer " + Config.FORGE_FILE + "...");

            try {
                //TODO: detect no system java and run using MC captive.
                var proc = Process.Start(Path.Combine(Global.customJavaPath, "javaw"), "-jar " + path);
                //TODO do I care about stdout, stderr?
                proc.WaitForExit();
                return checkForge();
            } catch (Exception ex) {
                log("This shouldn't happen " + ex.Message);
            } finally {
                try { //cleanup
                    if (File.Exists(path))
                        File.Delete(path);
                    if (File.Exists(path + ".log")) //i hate this thing.
                        File.Delete(path + ".log");
                } catch (Exception) {
                }
            }

            return false;
        }

    }
}
