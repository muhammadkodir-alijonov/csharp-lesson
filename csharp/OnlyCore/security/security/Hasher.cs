using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace security.security;

public class Hasher
{
    private const string _slat = "dskfnsjdn2344n32-p3c2irc2jn3r0cr23r2-f------23c4r23rc";
    public static string Hash(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password + _slat));
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
