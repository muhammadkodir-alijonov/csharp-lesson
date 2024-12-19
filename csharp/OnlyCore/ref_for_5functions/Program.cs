namespace ref_out_functions;

public class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        // "ref" bilan funksiya argumentini o'zgartirish
        AddRef(ref a, b);
        Console.WriteLine(a); // 30

        // "out" bilan funksiya argumentini o'zgartirish
        AddOut(out a, b);
        Console.WriteLine(a); // 60
    }

    static void AddRef(ref int x, int y)
    {
        x += y;
    }

    static void AddOut(out int x, int y)
    {
        x = 40;
        x += y;
    }

}