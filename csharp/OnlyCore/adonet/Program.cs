using adonet.Interface.Repositories;
using adonet.Models;
using adonet.Repositories571632;
using Npgsql;

namespace adonet;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.Write("Email : ");
        string email = Console.ReadLine();
        Console.Write("Password : ");
        string password = Console.ReadLine();
        IUserRepository userRepository = new UserRepository();
        var user = await userRepository.FindEmailAsync(email);
        Console.WriteLine(user.FullName + " " + user.Adress);
    }
}