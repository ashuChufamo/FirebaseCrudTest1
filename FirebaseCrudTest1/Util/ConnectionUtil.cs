using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseCrudTest1.Util
{
    public static class ConnectionUtil
    {
        public static bool net_available = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

        public static bool CheckConnection()
        {
            if (net_available)
            {
                /* try
                 {
                     Ping p = new Ping();
                     PingReply r = p.Send("www.google.com", 1000);
                     if (r.Status == IPStatus.Success)
                     {
                         return true;
                     }
                 }
                 catch
                 {
                     return false;

                 }*/
                try
                {
                    using (var client = new System.Net.WebClient())
                    using (client.OpenRead("http://google.com/generate_204"))
                        return true;
                }
                catch
                {
                    return false;
                }



            }
            return false;
        }
    }
}
