using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivecraftInstaller
{
    class Config
    {

        public static string homebase = "https://api.github.com/repos/jrbudda/VivecraftInstaller/releases";
        public static string versionsUrl = "http://vivecraft.org/json/versions.json";

        /* These are populated based on selected version*/
        public static bool ALLOW_FORGE_INSTALL = true;
        public static bool DEFAULT_FORGE_INSTALL = false;
        public static bool ALLOW_KATVR_INSTALL = true;
        public static bool ALLOW_KIOSK_INSTALL = true;
        public static bool ALLOW_ZGC_INSTALL = true;
        public static bool ALLOW_HRTF_INSTALL = false;
        public static bool PROMPT_REMOVE_HRTF = false;
        public static string MC_VERSION = "1.16.5";
        public static string FORGE_VERSION = "36.0.7";
        public static string PROJECT_NAME = "Vivecraft";
        public static string JAR_ID = "Vivecraft";
        /**/

        public static string HOMEPAGE_LINK = "http://www.vivecraft.org";
        public static string DONATION_LINK = "https://www.patreon.com/jrbudda";
        public static string DEFAULT_PROFILE_NAME = PROJECT_NAME + " " + MC_VERSION;
        public static string DEFAULT_PROFILE_NAME_FORGE = PROJECT_NAME + "-Forge " + MC_VERSION;
        public static string ORIG_FORGE_VERSION = FORGE_VERSION;


        
        public static bool isMultiMC;
        public static string mmcinst;

        public static bool isForge;
        public static string forgeVersion;

        public static bool isShadersMod;

        public static string targetDir;
        public static bool createProfile;

        public static bool isKatVR;
        public static bool isKiosk;

    }
}
