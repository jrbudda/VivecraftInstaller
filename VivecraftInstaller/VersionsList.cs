using System.Collections.Generic;

namespace VivecraftInstaller
{
    public class VersionList
    {
        public Version[] versions { get; set; }
    }

    public class Version
    {
        public string version { get; set; }
        public string vrcfg { get; set; }
        public string nonvrcfg { get; set; }
        public string releases { get; set; }

        public Config configVR = null;
        public Config configNONVR = null;

        public override string ToString()
        {
            return version;
        }
    }
}
