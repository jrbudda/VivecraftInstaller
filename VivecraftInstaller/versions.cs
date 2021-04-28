using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivecraftInstaller
{
    public class Version
    {
        public string version { get; set; }
        public string cfg { get; set; }
        public string jar { get; set; }
        public string json_std { get; set; }
        public string json_mmc { get; set; }
        public string json_frg { get; set; }
        public string json_mmcfrg { get; set; }
    }

    public class VersionList
    {
        public string latest { get; set; }
        public IList<Version> versions { get; set; }
    }

}
