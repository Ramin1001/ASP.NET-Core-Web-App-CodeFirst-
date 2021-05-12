using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Service
{
    public static class Extentions
    {
        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }
    }
}
