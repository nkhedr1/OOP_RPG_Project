using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop
    {

        public List<Armor> ArmorShop { get; set; }
        public List<Weapon> WeaponShop { get; set; }
        public List<HealthPotion> PotionShop { get; set; }
        public Hero Hero { get; set; }
        int num { get; set; }

        public Shop(Hero hero)
        {
            ArmorShop = new List<Armor>();
            WeaponShop = new List<Weapon>();
            PotionShop =  new List<HealthPotion>();
            Hero = hero;

        }

        public void SellArmor()
        {
            num = 1;
            ArmorShop = new List<Armor>
            {
                new Armor("Leather Armor", 10, 8),
                new Armor("Mail Armor", 12, 14),
                new Armor("Plate Armor", 15, 18)
            };

            foreach (Armor armor in ArmorShop)
            {

                Console.WriteLine(num + ". Name: " + armor.Name + ", Defence: " + armor.Defense + ", Price: " + armor.Price + ".");
                num++;
            }

            Console.WriteLine("Please choose the armor you want to buy by entering a number!");

            var input = Console.ReadLine();

            if (input == "1")
            {
                if (Hero.Gold >= ArmorShop[0].Price)
                {
                    Hero.ArmorsBag.Add(ArmorShop[0]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }

            }
            else if (input == "2")
            {
                if (Hero.Gold >= ArmorShop[1].Price)
                {
                    Hero.ArmorsBag.Add(ArmorShop[1]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
            else if (input == "3")
            {
                if (Hero.Gold >= ArmorShop[2].Price)
                {
                    Hero.ArmorsBag.Add(ArmorShop[2]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
        }

        public void SellWeapons()
        {
            num = 1;
            WeaponShop = new List<Weapon>
            {
                new Weapon("Sword", 3, 5),
                new Weapon("Axe", 4, 12),
                new Weapon("CrossBow", 5, 15)
            };

            foreach (Weapon weapon in WeaponShop)
            {

                Console.WriteLine(num + ". Name: " + weapon.Name + ", Strength: " + weapon.Strength + ", Price: " + weapon.Price + ".");
                num++;
            }

            Console.WriteLine("Please choose the weapon you want to buy by entering a number!");

            var input = Console.ReadLine();

            if (input == "1")
            {
                if (Hero.Gold >= WeaponShop[0].Price)
                {
                    Hero.WeaponsBag.Add(WeaponShop[0]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
            else if (input == "2")
            {
                if (Hero.Gold >= WeaponShop[1].Price)
                {
                    Hero.WeaponsBag.Add(WeaponShop[1]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
            else if (input == "3")
            {
                if (Hero.Gold >= WeaponShop[2].Price)
                {
                    Hero.WeaponsBag.Add(WeaponShop[2]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
        }

        public void SellHealthPotions()
        {
            num = 1;
            PotionShop = new List<HealthPotion>
            {
                new HealthPotion("Health Potion", 7, 5),
                new HealthPotion("Strong Health Potion", 11, 10),
                new HealthPotion("Great Health Potion", 16, 15)
            };

            foreach (HealthPotion potion in PotionShop)
            {

                Console.WriteLine(num + ". Name: " + potion.Name + ", Health: " + potion.HealthRestored + ", Price: " + potion.Price + ".");
                num++;
            }

            Console.WriteLine("Please choose the potion you want to buy by entering a number!");

            var input = Console.ReadLine();

            if (input == "1")
            {
                if (Hero.Gold >= PotionShop[0].Price)
                {
                    Hero.PotionBag.Add(PotionShop[0]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
            else if (input == "2")
            {
                if (Hero.Gold >= PotionShop[1].Price)
                {
                    Hero.PotionBag.Add(PotionShop[1]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
            else if (input == "3")
            {
                if (Hero.Gold >= PotionShop[2].Price)
                {
                    Hero.PotionBag.Add(PotionShop[2]);
                }
                else
                {
                    Console.WriteLine("Not Enough Gold!");
                }
            }
        }
    }
}
