using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;

namespace VivecraftInstaller {
    class Util {
        public static bool checkMD5(FileInfo a, String b) {
            if (a.Exists == false) return false;
            if (b == null) return true;
            return GetMd5(a).ToLower().Equals(b.ToLower());
        }

        public static string GetMd5(FileInfo fo) {
            if (!fo.Exists)
                return null;

            if (fo.Length < 1)
                return null;

            using (var md5 = MD5.Create()) {
                using (var stream = File.OpenRead(fo.FullName)) {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        public static string getWebRequestwithTimeout(string address, short timeoutS) {
            var w = new myWebClient();
            w.Headers.Add("User-Agent", "Vivecraft Installer");
            w.Timeout = timeoutS;
            w.Encoding = Encoding.UTF8;
            {
                try {
                    var ret = w.DownloadString(address);
                    return ret;
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

        public static byte[] getWebBinarywithTimeout(string address, short timeoutS) {
            var w = new myWebClient();
            w.Timeout = timeoutS;
            {
                try {
                    var ret = w.DownloadData(address);
                    return ret;
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

        public static string[] getGPU() {
            SelectQuery queryVideo = new SelectQuery("Win32_VideoController");
            ManagementObjectSearcher searchVideo = new ManagementObjectSearcher(queryVideo);
            var ret = new List<string>();
            foreach (ManagementObject video in searchVideo.Get()) {
                ret.Add(video["Name"].ToString());
            }
            return ret.ToArray();
        }

        public static string getJava(string path = "") {
            var p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = Path.Combine(path, "java");
            p.StartInfo.Arguments = "-version";
            p.EnableRaisingEvents = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;

            var ret = new List<string>();

            p.OutputDataReceived += (s, e) => {
                ret.Add(e.Data);
            };

            p.ErrorDataReceived += (s, e) => {
                ret.Add(e.Data);
            };

            p.Start();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.WaitForExit();

            foreach (string line in ret) {
                if (line.ToLower().Contains("version")) {
                    int a = line.IndexOf('"') + 1;
                    int b = line.LastIndexOf('"') - a;

                    return line.Substring(a, b);
                }
            }

            return "";
        }

        public static int parseJavaVersion(String version) {
            try {
                if (version.IndexOf('.') != -1)
                    return int.Parse(version.Substring(0, version.IndexOf('.')));
                else
                    return int.Parse(version);
            } catch (Exception) {
                throw new ApplicationException("Invalid Java version: " + version);
            }
        }

        /*
* If the user decides to not select the Java runtime at installation, this function will
* return the same value that was passed to it. In this case, the profile should not be changed.
 */
        //      private string checkForJava14(string path)
        //      {
        //          string newPath = path;
        //          bool first = true;
        //          while (true)
        //          {
        //              string ver = !newPath.isEmpty() ? getJavaVersionFromPath(newPath) : "0.0.0";
        //              if (parseJavaVersion(ver) >= 14 && parseJavaVersion(ver) <= 15)
        //                  break;

        //              if (first)
        //              {
        //                  string javaHome = System.getProperty("java.home") + (isWindows ? "\\bin\\javaw.exe" : "/bin/java");
        //                  string homeVer = getJavaVersionFromPath(javaHome);
        //                  if (parseJavaVersion(homeVer) >= 14 && parseJavaVersion(homeVer) <= 15)
        //                      return javaHome;
        //                  first = false;
        //              }

        //              int res = JOptionPane.showConfirmDialog(null,
        //                      "The currently selected Java executable is not Java 14 or Java 15.\n" +
        //                      "Would you like to select the correct one now?",
        //                      "Wrong Java Version",
        //                      JOptionPane.YES_NO_OPTION,
        //                      JOptionPane.ERROR_MESSAGE
        //              );
        //              if (res != JOptionPane.YES_OPTION)
        //                  return path;

        //              JFileChooser fileChooser = new JFileChooser();
        //              fileChooser.setFileSelectionMode(JFileChooser.FILES_ONLY);
        //              fileChooser.setFileHidingEnabled(false);
        //              if (isWindows)
        //                  fileChooser.setCurrentDirectory(new File(System.getenv("ProgramFiles")));
        //              fileChooser.setFileFilter(new FileFilter() {
        //                  @Override

        //                  public boolean accept(File f)
        //              {
        //                  if (!f.isFile())
        //                      return true;
        //                  return isWindows ? f.getName().equals("javaw.exe") : f.getName().equals("java");
        //              }

        //              @Override

        //                  public string getDescription()
        //              {
        //                  return "Java Executable";
        //              }
        //          });
        //          int response = fileChooser.showOpenDialog(null);
        //          if (response == JFileChooser.APPROVE_OPTION)
        //              newPath = fileChooser.getSelectedFile().getAbsolutePath();
        //      }

        //	return newPath;
        //}

    }
}
