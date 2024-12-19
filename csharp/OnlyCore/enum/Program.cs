class Program
{
    public static void Main()
    {
        /* // 1
         HaftaKunlari haftakuni = HaftaKunlari.Chorshanba;
         if (haftakuni == HaftaKunlari.Yakshanba)
         {
             Console.WriteLine("Bugun dam");
         }
         else if (haftakuni == HaftaKunlari.Dushanba)
         {
             Console.WriteLine("Yana o'qish");
         }
         else Console.WriteLine("Dam yo'q");*/
    }
    /* //1public enum HaftaKunlari
    {
        Dushanba, Seshanba, Chorshanba, 
        Payshanba, Juma, Shanba, Yakshanba
    }*/
    public static void Run(Fasl fasl)
    {
        if (fasl == Fasl.Bahor) Console.WriteLine("Bahor keldi");
        else if (fasl == Fasl.Yoz) Console.WriteLine("Yoz keldi");
        else Console.WriteLine("Fasil yo'q");
    }
}
public enum Fasl
{
    Bahor, Yoz, Kuz, Qish
}