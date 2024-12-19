using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incupsulation.Models
{
    public  class Father
    {
        protected double _money;
        protected string _key;
        protected const double _childMaxDailyMoneyUsage = 50000;
        public Father(double money, string key)
        {
            _money = money; 
            _key = key;

        }
        public void Showbalance()
        {
            Console.WriteLine($"balansigiz: {_money}");
        }
        public virtual void SpendMoney(double money, string key)
        {
            if(key == _key)
            {
                if (_money >= money)
                {
                    _money -= money;
                }
                else Console.WriteLine("Sizda soqqa yeatrli emas!");
            }
            else Console.WriteLine("Sizga ruxsat yo'q!");  
        }
        public void Addmoney(double money)
        {
            _money += money;
        }
    }
}
