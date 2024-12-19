using json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Data
{
    public class UserData
    {
        List<User> users = new List<User>()
        {
            new User()
            {
            Id = 1,
            FirstName = "Muhammad",
            LastName = "Alijonov",
            Email = "Alijonov@gmail.com",
            Password = "admin"
            }
            ,
            new User()
            {
            Id = 2,
            FirstName = "Izzat",
            LastName = "komilov",
            Email = "izzat@gmail.com",
            Password = "admin2"
            }
        };
    }
}
