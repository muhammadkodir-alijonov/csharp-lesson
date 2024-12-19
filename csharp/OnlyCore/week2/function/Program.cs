class Program
{
    public static void Main()
    {

        /*//function simple example
        int n = 100;
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i)) Console.WriteLine(i);
        }*/


        // ref bilan ish;ash ref kalit so'zi umimiy qiymatni tagi bln olib methodga bervorvoradi ref siz yozsak shunchaki qiymatdan copya olib bervoradi 
        /*int n = 10;
        AddNumber(ref n);
        Console.WriteLine(n);*/


        // a sonni b ga o'zgartirish
        /*int a = 10;
        int b = 20;
        Swap(ref a, ref b);
        Console.WriteLine(a);
        Console.WriteLine(b);*/



        // out da mainda qiymat bo'lishi shart emas lekinr ref da main da qiymat bo'lishi kerak.
        /*  double c;
        Calculate(2, 4, out c);
        Console.WriteLine(c);
        Console.WriteLine(Calculate(2, 3, out c));*/

    }
    /*public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++) 
        {
            if(n % i == 0) return false;
        }
        return true;
    }*/
    /*public static void AddNumber(ref int n)
    {
         n+= 5;
    }*/
    /* public static void Swap(ref int a, ref int b)
    {
        int x = a;
        a= b;
        b= x;
    }*/
    /*public static int Calculate(int a, int b, out double c)
    {
        int summ = a + b;
        c = Math.Pow(a, b);
        return summ;
    }*/
}
