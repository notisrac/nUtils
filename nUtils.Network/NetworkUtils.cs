using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace nUtils.Network
{
    public static class NetworkUtils
    {
        public static bool CheckInternetConnection()
        {
            try
            {
                return new Ping().Send("www.google.com").Status == IPStatus.Success;
            }
            catch (Exception)
            {
                // do nothing
            }

            return false;
        }

        public static string GetBaseURI(string sURL)
        {
            int iIndexOfQuerySeparator = sURL.IndexOf('?');
            if (-1 != iIndexOfQuerySeparator)
            {
                sURL = sURL.Substring(0, iIndexOfQuerySeparator);
            }
            int iLastSlash = sURL.LastIndexOf('/');
            if ((iLastSlash + 1) == sURL.Length)
            { // ends in / - so no file at the end
                return sURL;
            }
            int iLastDot = sURL.LastIndexOf('.');
            if (iLastSlash < iLastDot)
            { // there is a file at the end
                return sURL.Substring(0, iLastSlash + 1);
            }

            return sURL.TrimEnd(new char[] { '/' }) + "/";
        }

    }
}
