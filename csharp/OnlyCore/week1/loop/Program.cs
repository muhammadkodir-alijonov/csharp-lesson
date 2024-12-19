class Program
{
    public static void Main()
    {

        // 1 ?
        int i = 5;
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine((n > i) ? "katta" : "kichik");


        // 1.2 ?
        int f = 5;
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine((p >= i) ? ((p == 1) ? "teng" : "katta") : "kichik");
        Main();


        // math
        double j = 1.2;
        double target = Math.Round(j);// yaxlitlaydi
        double target2 = Math.Floor(j);// pastga urib yuboradi
        double target3 = Math.Ceiling(j);//yuqoriga urib beradi
        Console.WriteLine(target);
        Console.WriteLine(target2);
        Console.WriteLine(target3);

        // for
        //int n= 5;
        int summ = 0;
        for (int o = 0; o < 5; o++)
        {
            summ += o;
        }
        Console.WriteLine(summ);

        // while, do while, break
        while (true)
        { Console.WriteLine("salom"); }

#pragma warning disable CS0162 // Unreachable code detected
        string correctEmail = "alijonov@gmail.com";
#pragma warning restore CS0162 // Unreachable code detected
        string correctPassword = "12345";
        string email = "";
        string password = "";
        int counter = 0;
        do
        {
            if (counter == 5) break;
            counter++;
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
        } while (!(email == correctEmail && password == correctPassword));
        if (counter == 5) Console.WriteLine("Too many attempts");
        else Console.WriteLine("Success");



        // break
        int hakamSana = 0;
        while (true)
        {
            int secund = 0;
            while (true)
            {
                secund++;
                if (secund > 3 * 60)
                {
                    Console.WriteLine("Raund Tugadi!");
                    break;
                }
            }
        }



        // continue = skip qivoradi
        for (int a = 0; a < 100; a++)
        {
            if (a % 5 == 0) continue;
            Console.WriteLine(i);
        }

        //goto leap yani sakrab o'tib ketadi 
        bool active = false;
        string say = "Salom";
    key:
        if (active)
        {
            Console.WriteLine(say);
        }
        if (active == false)
        {
            active = true;
            goto key;
        }
        Console.ReadKey();

    }

}

