using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        private Hero Hero { get; }
        public Monster Enemy { get; set; }
        public MonsterSelector MonsterSelector { get; set; }
        public Random RandNum = new Random();
        private DayOfWeek CurrentDay = DateTime.Today.DayOfWeek;
        public Fight(Hero game)
        {
            Hero = game;
            MonsterSelector = new MonsterSelector();
            MonsterSelector.AddMonster();

            if (CurrentDay == DayOfWeek.Monday)
            {
                Enemy = MonsterSelector.Monsters[RandNum.Next(0, 5)];

            }
            else if (CurrentDay == DayOfWeek.Tuesday)
            {
                Enemy = MonsterSelector.Monsters2[RandNum.Next(0, 5)];
            }
            else if (CurrentDay == DayOfWeek.Wednesday)
            {
                Enemy = MonsterSelector.Monsters3[RandNum.Next(0, 5)];
            }
            else if (CurrentDay == DayOfWeek.Thursday)
            {
                Enemy = MonsterSelector.Monsters4[RandNum.Next(0, 5)];
            }
            else if (CurrentDay == DayOfWeek.Friday)
            {
                Enemy = MonsterSelector.Monsters5[RandNum.Next(0, 5)];
            }
            else if (CurrentDay == DayOfWeek.Saturday)
            {
                Enemy = MonsterSelector.Monsters6[RandNum.Next(0, 5)];
            }
            else if (CurrentDay == DayOfWeek.Sunday)
            {
                Enemy = MonsterSelector.Monsters7[RandNum.Next(0, 5)];
            }
        }

        public void Start()
        {
            while (Enemy.CurrentHP > 0 && Hero.CurrentHP > 0)
            {
                Console.WriteLine("You've encountered a " + Enemy.Name + "! " + Enemy.Strength + " Strength/" + Enemy.Defense + " Defense/" +
                Enemy.CurrentHP + " HP. What will you do?");

                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Run!!");

                var input = Console.ReadLine();

                if (input == "1")
                {
                    HeroTurn();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Please choose the potion to heal with by entering a number.");
                    int i;
                    for (i = 0; i < Hero.PotionBag.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1} {Hero.PotionBag[i].Name} of {Hero.PotionBag[i].HealthRestored} Health");
                    }

                    input = Console.ReadLine();
                    var inputNumber = Int32.Parse(input) - 1;
                    Hero.UseHealthPotion(inputNumber);
                }
                else if (input == "3")
                {
                    var chanceToRun = 0;
                    if (Enemy.Dificulty == MonsterDificulty.Easy)
                    {
                        chanceToRun = RandNum.Next(1, 3);
                        if (chanceToRun == 1)
                        {
                            HeroTurn();
                        }
                        else
                        {
                            Console.WriteLine("You get to live another day!!");
                            return;
                        }
                    }
                    else if (Enemy.Dificulty == MonsterDificulty.Medium)
                    {
                        chanceToRun = RandNum.Next(1, 5);
                        if (chanceToRun == 1)
                        {
                            HeroTurn();
                        }
                        else
                        {
                            Console.WriteLine("You get to live another day!!");
                            return;
                        }
                    }
                    else if (Enemy.Dificulty == MonsterDificulty.Hard)
                    {
                        chanceToRun = RandNum.Next(1, 21);
                        if (chanceToRun == 1)
                        {
                            HeroTurn();
                        }
                        else
                        {
                            Console.WriteLine("You get to live another day!!");
                            return;
                        }
                    }

                }
            }
        }

        private void HeroTurn()
        {
            var compare = Hero.TotalStrength - Enemy.Defense;
            int damage;
            int maxDamage = compare + (compare / 2);
            int minDamage = compare / 2;

            if (compare <= 0)
            {
                damage = 1;
                Enemy.CurrentHP -= damage;
            }
            else if (maxDamage <= 0)
            {

                damage = 1;
                Enemy.CurrentHP -= damage;
            }
            else if (minDamage <= 0)
            {

                damage = 1;
                Enemy.CurrentHP -= damage;
            }
            else
            {

                damage = RandNum.Next(minDamage, maxDamage);
                Enemy.CurrentHP -= damage;
            }

            Console.WriteLine("You did " + damage + " damage!");

            if (Enemy.CurrentHP <= 0)
            {
                Win();
            }
            else
            {
                MonsterTurn();
            }
        }

        private void MonsterTurn()
        {
            int damage;
            var compare = Enemy.Strength - Hero.TotalDefense;
            int maxDamage;
            int minDamage;

            if (compare <= 0)
            {
                damage = 1;
                Hero.CurrentHP -= damage;
            }
            else
            {
                maxDamage = compare + (compare / 2);
                minDamage = compare / 2;
                damage = RandNum.Next(minDamage, maxDamage);
                Hero.CurrentHP -= damage;
            }

            Console.WriteLine(Enemy.Name + " does " + damage + " damage!");

            if (Hero.CurrentHP <= 0)
            {
                Lose();
            }
        }

        private void Win()
        {
            var EasyMonsterGoldGenerator = RandNum.Next(1, 11);
            var MedMonsterGoldGenerator = RandNum.Next(11, 21);
            var HardMonsterGoldGenerator = RandNum.Next(21, 30);

            Hero.KillingScore += 1;

            if (Hero.KilledMonsters.Any() && !Hero.KilledMonsters.Contains(Enemy.Name))
            {
                Hero.KilledMonsters.Add(Enemy.Name);
            }
            else if (!Hero.KilledMonsters.Any())
            {
                Hero.KilledMonsters.Add(Enemy.Name);
            }

            Console.WriteLine(Enemy.Name + " has been defeated! You win the battle!");

            if (Enemy.Dificulty == MonsterDificulty.Easy)
            {
                Hero.Gold = Hero.Gold + EasyMonsterGoldGenerator;
                Console.WriteLine(Hero.Name + " receives " + EasyMonsterGoldGenerator + " Gold!");
            }
            else if (Enemy.Dificulty == MonsterDificulty.Medium)
            {
                Hero.Gold = Hero.Gold + MedMonsterGoldGenerator;
                Console.WriteLine(Hero.Name + " receives " + MedMonsterGoldGenerator + " Gold!");
            }
            else if (Enemy.Dificulty == MonsterDificulty.Hard)
            {
                Hero.Gold = Hero.Gold + HardMonsterGoldGenerator;
                Console.WriteLine(Hero.Name + " receives " + HardMonsterGoldGenerator + " Gold!");
            }

            Hero.Achivments();
        }

        private void Lose()
        {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            Console.WriteLine("Press any key to exit the game");
            Console.ReadKey();
        }
    }
}