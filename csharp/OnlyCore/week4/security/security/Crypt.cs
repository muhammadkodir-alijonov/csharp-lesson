using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security.security
{
    public class Crypt
    {
        private const byte _key = 4;
        public static string EnCrypt(string meesgage)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in meesgage)
            {
                char cryptedLetter = (char)(letter + _key);
                sb.Append(cryptedLetter);
            }
            return sb.ToString();
        }
        public static string DeCrypt(string meesgage)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in meesgage)
            {
                char cryptedLetter = (char)(letter - _key);
                sb.Append(cryptedLetter);
            }
            return sb.ToString();
        }

    }
}
