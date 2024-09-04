using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Utility.Convert
{
    public static class ComputerNameToIP
    {
        public static string CNameToIP(this string parametr)
        {
            IPHostEntry ips = Dns.GetHostByName(parametr);
            IPAddress[] IPAddress = ips.AddressList;
            return IPAddress[0].ToString();
        }
    }
}
