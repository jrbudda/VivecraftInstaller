using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VivecraftInstaller
{
    class myWebClient : WebClient
    {
        public short Timeout { get; set; } = 5;
        // Methods
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest webRequest = base.GetWebRequest(address);
            webRequest.Timeout = 1000 * Timeout;
            return webRequest;
        }
    }
}
