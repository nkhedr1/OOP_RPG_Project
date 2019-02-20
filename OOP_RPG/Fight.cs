using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Fight
    {
        private List<Monster> Monsters { get; }
        private List<Monster> Monsters2 { get; }
        private List<Monster> Monsters3 { get; }
        private List<Monster> Monsters4 { get; }
        private List<Monster> Monsters5 { get; }
        private List<Monster> Monsters6 { get; }
        private List<Monster> Monsters7 { get; }
        private Hero Hero { get; }
        Monster enemy;
        Random randNum = new Random();
        private DayOfWeek currentDay = DateTime.Today.DayOfWeek;


        public Fight(Hero game)
        {
            Hero = game;
            Monsters = new List<Monster>();
            Monsters2 = new List<Monster>();
            Monsters3 = new List<Monster>();
            Monsters4 = new List<Monster>();
            Monsters5 = new List<Monster>();
            Monsters6 = new List<Monster>();
            Monsters7 = new List<Monster>();
            AddMonster();

            if (currentDay == DayOfWeek.Monday)
            {
                enemy = Monsters[randNum.Next(0, 4)];
            }
            else if (currentDay == DayOfWeek.Tuesday)
            {
                enemy = Monsters2[randNum.Next(0, 4)];
            }
            else if (currentDay == DayOfWeek.Tuesday)
            {
                enemy = Monsters2[randNum.Next(0, 4)];
            }
            else if (currentDay == DayOfWeek.Wednesday)
            {
                enemy = Monsters3[randNum.Next(0, 4)];
            }
            else if (currentDay == DayOfWeek.Thursday)
            {
                enemy = Monsters4[randNum.Next(0, 4)];
            }
            else if (currentDay == DayOfWeek.Friday)
            {
                enemy = Monsters5[randNum.Next(0, 4)];
            }
            else if (currentDay == DayOfWeek.Saturday)
            {
                enemy = Monsters6[randNum.Next(0, 4)];
            }
            else if (currentDay == DayOfWeek.Sunday)
            {
                enemy = Monsters7[randNum.Next(0, 4)];
            }


        }

        private void AddMonster()
        {
            Monster monster1 = new Monster("Squid", 15, 5, 20, Monster.Difficulty.Medium);
            Monster monster2 = new Monster("Spider", 7, 3, 15, Monster.Difficulty.Easy);
            Monster monster3 = new Monster("Dragon", 20, 8, 30, Monster.Difficulty.Hard);
            Monster monster4 = new Monster("Bear", 19, 7, 25, Monster.Difficulty.Hard);
            Monster monster5 = new Monster("Lion", 13, 4, 21, Monster.Difficulty.Medium);
            Monster monster6 = new Monster("Unicorn", 14, 5, 21, Monster.Difficulty.Medium);
            Monster monster7 = new Monster("Snake", 5, 3, 12, Monster.Difficulty.Easy);
            Monster monster8 = new Monster("Eagle", 14, 4, 22, Monster.Difficulty.Medium);
            Monster monster9 = new Monster("Ant", 8, 4, 16, Monster.Difficulty.Easy);
            Monster monster10 = new Monster("Skeleton", 15, 5, 23, Monster.Difficulty.Medium);
            Monster monster11 = new Monster("Giant", 24, 9, 28, Monster.Difficulty.Hard);
            Monster monster12 = new Monster("Goblin", 13, 5, 21, Monster.Difficulty.Medium);
            Monster monster13 = new Monster("Zombie", 9, 3, 14, Monster.Difficulty.Easy);
            Monster monster14 = new Monster("Murloc", 8, 4, 15, Monster.Difficulty.Easy);
            Monster monster15 = new Monster("Reaper", 6, 2, 10, Monster.Difficulty.Easy);
            Monster monster16 = new Monster("Undead", 23, 8, 28, Monster.Difficulty.Hard);
            Monster monster17 = new Monster("Ghost", 25, 6, 31, Monster.Difficulty.Hard);
            Monster monster18 = new Monster("Ghoul", 23, 8, 30, Monster.Difficulty.Hard);
            Monster monster19 = new Monster("Bat", 8, 3, 12, Monster.Difficulty.Easy);
            Monster monster20 = new Monster("Orc", 14, 6, 22, Monster.Difficulty.Medium);
            Monster monster21 = new Monster("Cyclops", 25, 10, 29, Monster.Difficulty.Hard);
            Monster monster22 = new Monster("Mummy", 7, 2, 8, Monster.Difficulty.Easy);
            Monster monster23 = new Monster("Demon", 16, 5, 20, Monster.Difficulty.Medium);
            Monster monster24 = new Monster("Ogre", 24, 9, 28, Monster.Difficulty.Hard);
            Monster monster25 = new Monster("Gnoll", 6, 3, 9, Monster.Difficulty.Easy);
            Monster monster26 = new Monster("Werewolf", 15, 4, 20, Monster.Difficulty.Medium);
            Monster monster27 = new Monster("Minotaur", 25, 8, 29, Monster.Difficulty.Hard);
            Monster monster28 = new Monster("Harpy", 6, 3, 6, Monster.Difficulty.Easy);
            Monster monster29 = new Monster("Scorpion", 15, 4, 21, Monster.Difficulty.Medium);
            Monster monster30 = new Monster("Lich", 23, 11, 32, Monster.Difficulty.Hard);
            Monster monster31 = new Monster("Worm", 5, 1, 6, Monster.Difficulty.Easy);
            Monster monster32 = new Monster("Hydra", 14, 4, 19, Monster.Difficulty.Medium);
            Monster monster33 = new Monster("Griffon", 23, 8, 29, Monster.Difficulty.Hard);
            Monster monster34 = new Monster("Crab", 4, 2, 5, Monster.Difficulty.Easy);
            Monster monster35 = new Monster("Amazon", 15, 3, 22, Monster.Difficulty.Medium);


            Monsters.Add(monster1);
            Monsters.Add(monster2);
            Monsters.Add(monster3);
            Monsters.Add(monster4);
            Monsters.Add(monster5);
            Monsters2.Add(monster6);
            Monsters2.Add(monster7);
            Monsters2.Add(monster8);
            Monsters2.Add(monster9);
            Monsters2.Add(monster10);
            Monsters3.Add(monster11);
            Monsters3.Add(monster12);
            Monsters3.Add(monster13);
            Monsters3.Add(monster14);
            Monsters3.Add(monster15);
            Monsters4.Add(monster16);
            Monsters4.Add(monster17);
            Monsters4.Add(monster18);
            Monsters4.Add(monster19);
            Monsters4.Add(monster20);
            Monsters5.Add(monster21);
            Monsters5.Add(monster22);
            Monsters5.Add(monster23);
            Monsters5.Add(monster24);
            Monsters5.Add(monster25);
            Monsters6.Add(monster26);
            Monsters6.Add(monster27);
            Monsters6.Add(monster28);
            Monsters6.Add(monster29);
            Monsters6.Add(monster30);
            Monsters7.Add(monster31);
            Monsters7.Add(monster32);
            Monsters7.Add(monster33);
            Monsters7.Add(monster34);
            Monsters7.Add(monster35);
        }

        public void Start()
        {

            while (enemy.CurrentHP > 0 && Hero.CurrentHP > 0)
            {
                Console.WriteLine("You've encountered a " + enemy.Name + "! " + enemy.Strength + " Strength/" + enemy.Defense + " Defense/" +
                enemy.CurrentHP + " HP. What will you do?");

                Console.WriteLine("1. Fight");

                var input = Console.ReadLine();

                if (input == "1")
                {
                    HeroTurn();

                }
            }
        }

        private void HeroTurn()
        {

            var compare = Hero.Strength - enemy.Defense;
            int damage;

            if (compare <= 0)
            {
                damage = 1;
                enemy.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                enemy.CurrentHP -= damage;
            }

            Console.WriteLine("You did " + damage + " damage!");

            if (enemy.CurrentHP <= 0)
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
            var compare = enemy.Strength - Hero.Defense;

            if (compare <= 0)
            {
                damage = 1;
                Hero.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                Hero.CurrentHP -= damage;
            }

            Console.WriteLine(enemy.Name + " does " + damage + " damage!");

            if (Hero.CurrentHP <= 0)
            {
                Lose();
            }
        }

        private void Win()
        {
            Console.WriteLine(enemy.Name + " has been defeated! You win the battle!");
        }

        private void Lose()
        {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            Console.WriteLine("Press any key to exit the game");
            Console.ReadKey();
        }
    }
}