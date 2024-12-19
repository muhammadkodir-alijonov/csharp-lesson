

// firstly
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("salom");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("dunyo");
Console.BackgroundColor = ConsoleColor.Black;



// secnodly bayroq
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("                        ");
Console.WriteLine("                        ");
Console.WriteLine("                        ");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("                        ");
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("                        ");
Console.WriteLine("                        ");
Console.WriteLine("                        ");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("                        ");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("                        ");
Console.WriteLine("                        ");
Console.WriteLine("                        ");
Console.BackgroundColor = ConsoleColor.Black;




// thirdly login page
Console.Write("Login: ");
string login = Console.ReadLine();
Console.Write("Password: ");
string password = Console.ReadLine();

if (login == "admin" && password == "12345")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("seccusseflly");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your login or pssword is not correct");
}
Console.ResetColor();




// bool
bool a = (true && false || true && false);
Console.WriteLine(a);




// switch
int n = 7;
switch (n)
{
    case 0:
        Console.WriteLine("nol"); break;
    case 1:
        Console.WriteLine("bir"); break;
    case 2:
        Console.WriteLine("ikki"); break;
    case 3:
        Console.WriteLine("uch"); break;
    case 4:
        Console.WriteLine("tort"); break;
    case 5:
        Console.WriteLine("besh"); break;
    case 6:
        Console.WriteLine("olti"); break;
    case 7:
        Console.WriteLine("yetti"); break;
    case 8:
        Console.WriteLine("sakkiz"); break;

    case 9:
        Console.WriteLine("to'qqiz"); break;
    default:
        Console.WriteLine("Raqam emas"); break;

}