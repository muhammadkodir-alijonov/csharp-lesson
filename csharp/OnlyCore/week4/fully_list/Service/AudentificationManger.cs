using fully_list.Interface;
using fully_list.MockData;
using fully_list.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fully_list.Service
{
    public class AudentificationManger : IAudentificationManager
    {
        public User Verify(string email, string password)
        {
            foreach (var user in Data.Users)
            {
                if(email == user.Email && password == user.Password)
                {
                    return user;
                }
            }
            return null!;
        }
    }
}
