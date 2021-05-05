using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivecraftInstaller
{
    public class Config
    {
        /* These are populated based on parsed minecriftversion.py*/
        public bool ALLOW_FORGE_INSTALL = true;
        public bool DEFAULT_FORGE_INSTALL = false;
        public bool ALLOW_KATVR_INSTALL = true;
        public bool ALLOW_KIOSK_INSTALL = true;
        public bool ALLOW_ZGC_INSTALL = true;
        public bool ALLOW_HRTF_INSTALL = false;
        public bool PROMPT_REMOVE_HRTF = false;
        public string MC_VERSION = "";
        public string FORGE_VERSION = "";
        public string PROJECT_NAME = "Vivecraft";
        public string VIVECRAFT_VERSION = "";
        //


        public bool isNonVR = false;

        public string DEFAULT_PROFILE_NAME
        {
            get
            {
                return PROJECT_NAME + " " + MC_VERSION;
            }
        }

        public string DEFAULT_PROFILE_NAME_FORGE
        {
            get
            {
                return PROJECT_NAME + "-Forge " + MC_VERSION;
            }
        }

        public string FULL_FORGE_VERSION
        {
            get
            {
                return MC_VERSION + "-" + FORGE_VERSION;
            }
        }
        public string FORGE_FILE
        {
            get
            {
                return "forge-" + FULL_FORGE_VERSION + "-installer.jar";
            }
        }
        public string FORGE_URL
        {
            get
            {
                return "https://files.minecraftforge.net/maven/net/minecraftforge/forge/" + FULL_FORGE_VERSION + "/" + FORGE_FILE;
            }
        }


        public Config(Dictionary<string, object> ret)
        {
            if (ret.ContainsKey("allow_forge"))
                this.ALLOW_FORGE_INSTALL = (bool)ret["allow_forge"];
            if (ret.ContainsKey("forge_default"))
                this.DEFAULT_FORGE_INSTALL = (bool)ret["forge_default"];
            if (ret.ContainsKey("allow_zgc"))
                this.ALLOW_ZGC_INSTALL = (bool)ret["allow_zgc"];
            if (ret.ContainsKey("allow_kiosk"))
                this.ALLOW_KIOSK_INSTALL = (bool)ret["allow_kiosk"];
            if (ret.ContainsKey("allow_katvr"))
                this.ALLOW_KATVR_INSTALL = (bool)ret["allow_katvr"];
            if (ret.ContainsKey("allow_hrtf"))
                this.ALLOW_HRTF_INSTALL = (bool)ret["allow_hrtf"];
            if (ret.ContainsKey("allow_remove_hrtf"))
                this.PROMPT_REMOVE_HRTF = (bool)ret["allow_remove_hrtf"];
            if (ret.ContainsKey("mc_version"))
                this.MC_VERSION = (string)ret["mc_version"];
            if (ret.ContainsKey("forge_version"))
                this.FORGE_VERSION = (string)ret["forge_version"];
            if (ret.ContainsKey("project_name"))
                this.PROJECT_NAME = (string)ret["project_name"];
            if (ret.ContainsKey("minecrift_build"))
                this.VIVECRAFT_VERSION = this.MC_VERSION + "-" + (string)ret["minecrift_build"];
        }
        /**/
    }
}
