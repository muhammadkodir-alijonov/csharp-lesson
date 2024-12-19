using json.Models;
using Newtonsoft.Json;

namespace json;

public class Program
{
    public static Currency Find(string code)
    {
        foreach (var currency in Currencies)
            if(code == currency.Code)
                return currency;
        return new Currency();
    }
    public static double UzsToUsd(double uzs)
    {
        var currency = Find("USD");
        return  uzs/currency.cb_price;
    }
    private static List<Currency> Currencies = new List<Currency>();
    static void Main(string[] args)
    {
        string path = "D:\\dataDemo\\dataDemo.json";
        string json = File.ReadAllText(path);
        Currencies = JsonConvert.DeserializeObject<List<Currency>>(json);
        Console.WriteLine("'Dollir qilmoqchi bo'lgan summagizni kiriting = ");
        double uzs = double.Parse(Console.ReadLine());
        double usd = UzsToUsd(uzs);
        Console.WriteLine(usd);























        //User user = new User()
        //{
        //    Id = 1,
        //    FirstName = "Muhammad",
        //    LastName = "Alijonov",
        //    Email = "Alijonov@gmail.com",
        //    Password = "admin"
        //};

        //var json = JsonConvert.SerializeObject(users);
        //File.WriteAllText(path, json.ToString());

        //var result = File.ReadAllText(path);
        //var json = JsonConvert.DeserializeObject<List<User>>(result);
        //foreach (var user in json!)
        //{
        //    Console.WriteLine(user.FirstName + " " + user.LastName);
        //}

    }
}