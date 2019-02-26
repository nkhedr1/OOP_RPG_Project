using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Hero
    {
        // These are the Properties of our Class.
        public string Name { get; set; }
        public int Strength { get; set; }
        public int TotalStrength { get; set; }
        public int Defense { get; set; }
        public int TotalDefense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }
        public Weapon EquippedWeapon { get; private set; }
        public Armor EquippedArmor { get; private set; }
        public List<Armor> ArmorsBag { get; set; }
        public List<Weapon> WeaponsBag { get; set; }
        public List<HealthPotion> PotionBag { get; set; }

        /*This is a Constructor.
        When we create a new object from our Hero class, the instance of this class, our hero, has:
        an empty List that has to contain instances of the Armor class,
        an empty List that has to contain instance of the Weapon class,
        stats of the "int" data type, including an intial strength and defense,
        original hitpoints that are going to be the same as the current hitpoints.
        */
        public Hero()
        {
            ArmorsBag = new List<Armor>();
            WeaponsBag = new List<Weapon>();
            PotionBag = new List<HealthPotion>();
            Strength = 10;
            TotalStrength = 10;
            Defense = 10;
            TotalDefense = 10;
            OriginalHP = 30;
            CurrentHP = 30;
            Gold = 20;
        }

        //These are the Methods of our Class.
        public void ShowStats()
        {
            Console.WriteLine("*****" + this.Name + "*****");
            if (this.EquippedWeapon != null)
            {
                Console.WriteLine("Strength: " + this.Strength + " + (" + this.EquippedWeapon.Strength + ")");
            }
            else
            {
                Console.WriteLine("Strength: " + this.Strength);
            }

            if (this.EquippedArmor != null)
            {
                Console.WriteLine("Defense: " + this.Defense + " + (" + this.EquippedArmor.Defense + ")");
            }
            else
            {
                Console.WriteLine("Defense: " + this.Defense);
            }

            Console.WriteLine("Hitpoints: " + this.CurrentHP + "/" + this.OriginalHP);
        }

        public void ShowInventory()
        {
            int num1 = 1;
            int num2 = 1;
            Console.WriteLine("*****  INVENTORY ******");
            Console.WriteLine("Weapons: ");

            foreach (var weapon in this.WeaponsBag)
            {
                Console.WriteLine(num1 + " " + weapon.Name + " of " + weapon.Strength + " Strength");
                num1++;
            }

            Console.WriteLine("Armor: ");

            foreach (var armor in this.ArmorsBag)
            {
                Console.WriteLine(num2 + " " + armor.Name + " of " + armor.Defense + " Defense");
                num2++;
            };

            Console.WriteLine("Potions: ");

            foreach (var potion in this.PotionBag)
            {
                Console.WriteLine(num1 + " " + potion.Name + " of " + potion.HealthRestored + " Health");
                num1++;
            }
            if (EquippedWeapon != null)
            {
                Console.WriteLine("Equipped Weapon: " + EquippedWeapon.Name);
            }
            else
            {
                Console.WriteLine("Equipped Weapon: None");
            };

            if (EquippedArmor != null)
            {
                Console.WriteLine("Equipped Armor: " + EquippedArmor.Name);
            }
            else
            {
                Console.WriteLine("Equipped Armor: None");
            };

            Console.WriteLine("Gold: " + Gold);
            Console.WriteLine("Please choose an option by entering a number.");
            Console.WriteLine("1. Equip Armor");
            Console.WriteLine("2. Equip Weapon");
            Console.WriteLine("3. UnEquip Armor");
            Console.WriteLine("4. UnEquip Weapon");
            Console.WriteLine("5. Heal");
            Console.WriteLine("6. Sell");
            Console.WriteLine("7. Return to Main Menu");

            var input = Console.ReadLine();
            int inputNumber = Int32.Parse(input) - 1;

            if (input == "1")
            {
                int num3 = 1;
                Console.WriteLine("Please choose the armor to equip by entering a number.");
                foreach (var armor in this.ArmorsBag)
                {
                    Console.WriteLine(num3 + " " + armor.Name + " of " + armor.Defense + " Defense");
                    num3++;
                };
                input = Console.ReadLine();
                inputNumber = Int32.Parse(input) - 1;
                this.EquipArmor(inputNumber);
            }
            else if (input == "2")
            {
                int num4 = 1;
                Console.WriteLine("Please choose the weapon to equip by entering a number.");
                foreach (var weapon in this.WeaponsBag)
                {
                    Console.WriteLine(num4 + " " + weapon.Name + " of " + weapon.Strength + " Strength");
                    num4++;
                }
                input = Console.ReadLine();
                inputNumber = Int32.Parse(input) - 1;
                this.EquipWeapon(inputNumber);
            }
            else if (input == "3")
            {
                this.EquippedArmor = null;
            }
            else if (input == "4")
            {
                this.EquippedWeapon = null;
            }
            else if (input == "5")
            {
                Console.WriteLine("Please choose the potion to heal with by entering a number.");
                int i;
                for (i = 0; i < this.PotionBag.Count(); i++)
                {
                    Console.WriteLine($"{i + 1} {this.PotionBag[i].Name} of {this.PotionBag[i].HealthRestored} Health");
                }

                input = Console.ReadLine();
                inputNumber = Int32.Parse(input) - 1;
                this.UseHealthPotion(inputNumber);
            }
            else if (input == "6")
            {
                Console.WriteLine("Please chose which item type to sell by entering a number.");
                Console.WriteLine("1. Armor");
                Console.WriteLine("2. Weapon");
                Console.WriteLine("3. Potion");
                var inputKey = Console.ReadLine();
                var inputNumber2 = Int32.Parse(inputKey) - 1;

                if (inputKey == "1")
                {
                    if (ArmorsBag.Any())
                    {
                        Console.WriteLine("Please choose the Armor to sell with by entering a number.");
                        int i;
                        for (i = 0; i < this.ArmorsBag.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1} {this.ArmorsBag[i].Name} of {this.ArmorsBag[i].Defense} Defence");
                        }
                        inputKey = Console.ReadLine();
                        inputNumber2 = Int32.Parse(inputKey) - 1;
                        SellBackArmor(inputNumber2);
                    }
                    else
                    {
                        Console.WriteLine("Armor Bag Empty");
                    }
                }
                else if (inputKey == "2")
                {
                    if (WeaponsBag.Any())
                    {
                        Console.WriteLine("Please choose the Weapon to sell by entering a number.");
                        int i;
                        for (i = 0; i < this.WeaponsBag.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1} {this.WeaponsBag[i].Name} of {this.WeaponsBag[i].Strength} Strength, Selling Price: {this.WeaponsBag[i].Price - 1}");
                        }
                        inputKey = Console.ReadLine();
                        inputNumber2 = Int32.Parse(inputKey) - 1;
                        SellBackWeapon(inputNumber2);
                    }
                    else
                    {
                        Console.WriteLine("Weapon Bag Empty");
                    }
                }
                else if (inputKey == "3")
                {
                    if (PotionBag.Any())
                    {
                        Console.WriteLine("Please choose the Potion to sell by entering a number.");
                        int i;
                        for (i = 0; i < this.PotionBag.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1} {this.PotionBag[i].Name} of {this.PotionBag[i].HealthRestored} Health");
                        }
                        inputKey = Console.ReadLine();
                        inputNumber2 = Int32.Parse(inputKey) - 1;
                        SellBackPotion(inputNumber2);
                    }
                    else
                    {
                        Console.WriteLine("Potion Bag Empty");
                    }
                }

            }
            else if (input == "7")
            {
                return;
            }
        }

        public void EquipWeapon(int inputNumber)
        {
            if (WeaponsBag.Any())
            {
                this.EquippedWeapon = this.WeaponsBag[inputNumber];
                this.TotalStrength += this.WeaponsBag[inputNumber].Strength;
            }
        }

        public void EquipArmor(int inputNumber)
        {
            if (ArmorsBag.Any())
            {
                this.EquippedArmor = this.ArmorsBag[inputNumber];
                this.TotalDefense += this.ArmorsBag[inputNumber].Defense;
            }
        }

        public void UseHealthPotion(int inputNumber)
        {
            if (PotionBag.Any())
            {
                int roundHP;
                roundHP = this.CurrentHP + this.PotionBag[inputNumber].HealthRestored;
                if (roundHP <= this.OriginalHP)
                {
                    this.CurrentHP = roundHP;
                }
                else
                {
                    this.CurrentHP = this.OriginalHP;
                }

                this.PotionBag.RemoveAt(inputNumber);
            }
        }

        public void SellBackWeapon(int inputNumber)
        {
            if (WeaponsBag.Any())
            {
                if (this.EquippedWeapon != null && (this.EquippedWeapon.Name == this.WeaponsBag[inputNumber].Name))
                {
                    Console.WriteLine("Item equipped, please unequip it from the inventory first and try again");
                }
                else
                {
                    this.Gold += (this.WeaponsBag[inputNumber].Price - 1);
                    this.WeaponsBag.RemoveAt(inputNumber);
                }
            }
        }

        public void SellBackArmor(int inputNumber)
        {
            if (ArmorsBag.Any())
            {
                if (this.EquippedArmor != null && (this.EquippedArmor.Name == this.ArmorsBag[inputNumber].Name))
                {
                    Console.WriteLine("Item equipped, please unequip it from the inventory first and try again");
                }
                else
                {
                    this.Gold += (this.ArmorsBag[inputNumber].Price - 1);
                    this.ArmorsBag.RemoveAt(inputNumber);
                }
            }
        }

        public void SellBackPotion(int inputNumber)
        {
            if (PotionBag.Any())
            {
                this.Gold += (this.PotionBag[inputNumber].Price - 1);
                this.PotionBag.RemoveAt(inputNumber);
            }
        }
    }
}