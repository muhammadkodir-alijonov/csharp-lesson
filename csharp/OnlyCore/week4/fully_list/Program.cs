using fully_list.Helpers;
using fully_list.Interface;
using fully_list.Service;

namespace fully_list
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Emailni kriting...");
            string email = Console.ReadLine();

            IPasswordReader passwordReader = new PasswordReader();
            Console.WriteLine("Passwordni kriting...");
            string password = passwordReader.ReadAsAnonym();
             
            IAudentificationManager audentificationManager = new AudentificationManger();
            var user = audentificationManager.Verify(email, password);

            if (user is null) OutputHelper.WriteError("User not found");
            else OutputHelper.WriteSuccessuful(user.FirstName + " " + user.LastName); 

        }
    }
}