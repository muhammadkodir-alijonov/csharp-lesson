using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incupsulation.Models
{
    public class Child : Father
    {
        public double DailyUsage { get; private set; }
        public DateOnly LastSpendDate { get; private set; }
        public Child(double money, string key)
            : base(money, key)
        {
            DailyUsage = 0;
            LastSpendDate = DateOnly.FromDateTime(DateTime.Now);
        }

        public override void SpendMoney(double money, string key)
        {
           if(key != _key)
            {
                Console.WriteLine("Sizda foydalanishga ruxsat yoq'");
                return;
            }
           if(money > _money)
            {
                Console.WriteLine("Sizda ushbu miqdor yetarli emas!");
                return;
            }
           if(AccessCheckMoney(money) is false)
            {
                Console.WriteLine("Sizda cheklovlar mavjud");
                Console.WriteLine($"Siz uchun kunlik limit {_childMaxDailyMoneyUsage} UZS");
                Console.WriteLine($"Siz bugn ishlatgan summangiz {DailyUsage} UZS");
                Console.WriteLine($"Siz bugun yani {_childMaxDailyMoneyUsage-DailyUsage} UZS ishlata olasiz");
                Console.WriteLine($" Siz so'rayotgan summa esa {money} UZS");
                return;
            }
            _money -= money;
            DailyUsage += money;

        }
        private bool AccessCheckMoney(double money)
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            if(currentDate != LastSpendDate)
            {
                LastSpendDate = currentDate;
                DailyUsage = 0;
            }
            double allmoney = money + DailyUsage;
            if(allmoney > _childMaxDailyMoneyUsage) return false;
            else return true;
        }
    }
}
