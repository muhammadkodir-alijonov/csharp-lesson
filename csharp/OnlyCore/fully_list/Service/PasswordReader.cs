using fully_list.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fully_list.Service;

public class PasswordReader : IPasswordReader
{
    public string ReadAsAnonym()
    {
        var password = string.Empty;
        ConsoleKey key;
        do
        {
            var keyinfo = Console.ReadKey(intercept: true);
            key = keyinfo.Key;
            if (key == ConsoleKey.Backspace && password.Length > 0)
            {
                Console.Write("\b\b");
                password = password[0..^1];
            }
            else if (!char.IsControl(keyinfo.KeyChar)) 
            {
                Console.Write("*");
                password += keyinfo.KeyChar;
            }
        } while (key != ConsoleKey.Enter);
        return password;
    }
}
