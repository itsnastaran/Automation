using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Utility.Convert
{
    public static class ConvertPassword
    {
        public static string PasswordToSHA256(this string paramert)
        {
            SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
            byte[] B1;
            Byte[] B2;
            B1 = UTF8Encoding.UTF8.GetBytes(paramert.Trim());
            B2 = SHA256.ComputeHash(B1);
            return BitConverter.ToString(B2);
        }
    }
}
