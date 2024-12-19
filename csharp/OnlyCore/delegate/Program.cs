using Models;

namespace learningdelegate;
public class Program
{
    public delegate bool Sender(string message);
   
    public static void Main(string[] args)
    {
        Sender sender = SendToInstagram;
        sender("bla bla barga gomi");
    }
    public static bool SendToInstagram(string message)
    {
        Console.WriteLine($"{message} so'zi");
        Console.WriteLine("Instagramdan keldi");
        return true;
    }
    public static bool SendToTelegram(string message)
    {
        Console.WriteLine($"{message} so'zi");
        Console.WriteLine("telegramdan keldi");
        return true;
    }

    /*    //tuple
        public static (bool isSucessful, string errorMessage) Run()
        {
            bool con = 5 < 4;
            if (con) return (isSucessful: true, errorMessage: " ");
            else return (isSucessful: false, errorMessage: "error bor ukam");
        }*/
}
