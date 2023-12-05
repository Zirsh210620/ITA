using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IT_ACADEMY
{
    internal class sha256
    {
        public static string ToSHA256(string s)
        {
            SHA256 s256 = SHA256.Create();

            byte[] bytes = s256.ComputeHash(Encoding.UTF8.GetBytes(s));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            //hellohello
            return sb.ToString(); //ddddddd
        }
    }
}
