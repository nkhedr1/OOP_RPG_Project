using System;

namespace OOP_RPG
{
    public class Game
    {
        public Hero Hero { get; set; }
        public Shop Shop { get; set; }

        public Game()
        {
            Hero = new Hero();
            Shop = new Shop(Hero);
        }

        public void Start()
        {
            Console.WriteLine("Welcome hero!");
            Console.WriteLine("Please enter your name:");
            Hero.Name = Console.ReadLine();
            Console.WriteLine("Hello " + Hero.Name);
            Main();
        }

        private void Main()
        {
            var input = "0";

            while (input != "5")
            {
                Console.WriteLine("Please choose an option by entering a number.");
                Console.WriteLine("1. View Stats");
                Console.WriteLine("2. View Inventory");
                Console.WriteLine("3. Fight Monster");
                Console.WriteLine("4. Buy Items");
                Console.WriteLine("5. Exit");

                input = Console.ReadLine();

                if (input == "1")
                {
                    this.Stats();
                }
                else if (input == "2")
                {
                    this.Inventory();
                }
                else if (input == "3")
                {
                    this.Fight();
                }
                else if (input == "4")
                {
                    this.Buy();

                }

                if (Hero.CurrentHP <= 0)
                {
                    return;
                }
            }
        }

        private void Stats()
        {
            Hero.ShowStats();
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        private void Inventory()
        {
            Hero.ShowInventory();
        }

        private void Fight()
        {
            var fight = new Fight(Hero);
            fight.Start();
        }

        private void Buy()
        {
            Console.WriteLine("Chose type of items to buy!");
            Console.WriteLine("1. Armor");
            Console.WriteLine("2. Weapon");
            Console.WriteLine("3. Potion");
            Console.WriteLine("4. Shield");
            Console.WriteLine("5. Return");
            var input2 = Console.ReadLine();
            while (input2 != "5")
            {
                if (input2 == "1")
                {
                    Shop.SellArmor();
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadKey();
                    return;
                }
                else if (input2 == "2")
                {
                    Shop.SellWeapons();
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadKey();
                    return;
                }
                else if (input2 == "3")
                {
                    Shop.SellHealthPotions();
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadKey();
                    return;
                }
                else if (input2 == "4")
                {
                    Shop.SellShield();
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}