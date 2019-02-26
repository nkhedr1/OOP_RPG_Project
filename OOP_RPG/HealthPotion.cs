using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class HealthPotion
    {
        public string Name { get; set; }
        public int HealthRestored { get; set; }
        public int Price { get; set; }

        public HealthPotion(string name, int healthRestored, int price)
        {
            Name = name;
            HealthRestored = healthRestored;
            Price = price;
        }
    }
}
