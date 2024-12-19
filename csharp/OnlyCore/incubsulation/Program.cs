using incupsulation.Models;

class Program
{
    public static void Main(string[] args)
    {
        Child child = new Child(5000000, "TTT");
        child.SpendMoney(40000, "TTT");
        child.SpendMoney(15000, "TTT");
        child.Showbalance();
    }
}