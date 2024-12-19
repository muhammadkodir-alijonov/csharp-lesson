using fully_list.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fully_list.MockData;

public class Data
{
    public static List<User> Users { get; set; } = new List<User>()
    {
        new User() {FirstName = "Muhammad", LastName = "Alijonov", Email = "alijonov@gmail.com", Password = "1", Role = Enum.Role.Admin},
        new User() { FirstName= "Izzat", LastName = "Komilov", Email = "komilov@gmail.com", Password = "1", Role = Enum.Role.User}
    };

    public static List<Teacher> teachers { get; set; } = new List<Teacher>()
    {
        new Teacher() {FirstName = "Shohiyda", LastName = "Niyzova", Email = "shohiyda@gmail.com", Password = "", Role = Enum.Role.User, Subject = "painting"}
    };
}
