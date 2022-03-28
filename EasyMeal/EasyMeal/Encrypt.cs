using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace EasyMeal
{
    public class Encrypt
    {
        public static string hashString(string passwordString)
        {
            var sb = new StringBuilder();
            foreach (byte b in getHash(passwordString))
            {
                sb.Append(b.ToString("X3"));
            }
            return sb.ToString();
        }

        public static byte[] getHash(string passwordString)
        {
            using (HashAlgorithm algo = SHA256.Create())
                return algo.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
        }
    }
}
