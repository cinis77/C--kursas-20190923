using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vartotojai
{
    internal class User
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public virtual double Pay(int amount)
        {
            return amount;
        }
    }

    internal class Vip : User
    {
        public DateTime ExpirationDate { get; set; }

        public override double Pay(int amount)
        {
            return base.Pay(amount) * 0.7;
        }
    }

    internal class Silver : User
    {
        public DateTime ExpirationDate { get; set; }

        public override double Pay(int amount)
        {
            return base.Pay(amount) * 0.9;
        }
    }

    internal class Basic : User
    {
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<User> users = new List<User> { new Vip(), new Silver(), new Basic() };
            foreach (var item in users)
            {
                Console.WriteLine(item.Pay(10));
            }
        }
    }
}