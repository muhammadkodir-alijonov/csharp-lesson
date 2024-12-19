using EfCore.DbContexts;
using EfCore.Models;

class Program
{
    public static void Main(string[] args)
    {
        AppDbContext appDbContext = new AppDbContext();
        var user = new User()
        {
            Firstname = "Sotvoldi",
            Lastname = "alimov",
            Address = "namagna",
            PhoneNumber = "+998945678822"
        };
        appDbContext.Users.Add(user);
        var result = appDbContext.SaveChanges();
        Console.WriteLine(result);
    }
}
