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
            Strength = 10;
            TotalStrength = 10;
            Defense = 10;
            TotalDefense = 10;
            OriginalHP = 30;
            CurrentHP = 30;
            Gold = 0;
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
            Console.WriteLine("5. Return to Main Menu");

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
    }
}