using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        private Hero Hero { get; }
        public Monster Enemy { get; set; }
        public Random randNum = new Random();
        private DayOfWeek currentDay = DateTime.Today.DayOfWeek;

        public Fight(Hero game)
        {
            Hero = game;
            var monsterSelector = new MonsterSelector();
            monsterSelector.AddMonster();

            if (currentDay == DayOfWeek.Monday)
            {
                Enemy = monsterSelector.Monsters[randNum.Next(0, 5)];
            }
            else if (currentDay == DayOfWeek.Tuesday)
            {
                Enemy = monsterSelector.Monsters2[randNum.Next(0, 5)];
            }
            else if (currentDay == DayOfWeek.Wednesday)
            {
                Enemy = monsterSelector.Monsters3[randNum.Next(0, 5)];
            }
            else if (currentDay == DayOfWeek.Thursday)
            {
                Enemy = monsterSelector.Monsters4[randNum.Next(0, 5)];
            }
            else if (currentDay == DayOfWeek.Friday)
            {
                Enemy = monsterSelector.Monsters5[randNum.Next(0, 5)];
            }
            else if (currentDay == DayOfWeek.Saturday)
            {
                Enemy = monsterSelector.Monsters6[randNum.Next(0, 5)];
            }
            else if (currentDay == DayOfWeek.Sunday)
            {
                Enemy = monsterSelector.Monsters7[randNum.Next(0, 5)];
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
                        chanceToRun = randNum.Next(1, 3);
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
                        chanceToRun = randNum.Next(1, 5);
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
                        chanceToRun = randNum.Next(1, 21);
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

                damage = randNum.Next(minDamage, maxDamage);
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
                damage = randNum.Next(minDamage, maxDamage);
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
            var EasyMonsterGoldGenerator = randNum.Next(1, 10);
            var MedMonsterGoldGenerator = randNum.Next(11, 20);
            var HardMonsterGoldGenerator = randNum.Next(21, 30);

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
        }

        private void Lose()
        {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            Console.WriteLine("Press any key to exit the game");
            Console.ReadKey();
        }
    }
}