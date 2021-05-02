using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivecraftInstaller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string resource1 = "VivecraftInstaller.ICSharpCode.SharpZipLib.dll";
            string resource2 = "VivecraftInstaller.Newtonsoft.Json.dll";
            EmbeddedAssembly.Load(resource1, "ICSharpCode.SharpZipLib.dll");
            EmbeddedAssembly.Load(resource2, "Newtonsoft.Json.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            var f = new frmMain();
            f.Show();
            Application.Run();
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
