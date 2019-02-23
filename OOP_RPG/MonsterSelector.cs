using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class MonsterSelector
    {
        public List<Monster> Monsters { get; set; }
        public List<Monster> Monsters2 { get; set; }
        public List<Monster> Monsters3 { get; set; }
        public List<Monster> Monsters4 { get; set; }
        public List<Monster> Monsters5 { get; set; }
        public List<Monster> Monsters6 { get; set; }
        public List<Monster> Monsters7 { get; set; }


        public MonsterSelector()
        {
            AddMonster();
        }

        public void AddMonster()
        {

            Monsters = new List<Monster>
            {
                new Monster("Squid", 15, 5, 20, MonsterDificulty.Medium),
                new Monster("Spider", 7, 3, 15, MonsterDificulty.Easy),
                new Monster("Dragon", 20, 8, 30, MonsterDificulty.Hard),
                new Monster("Bear", 19, 7, 25, MonsterDificulty.Hard),
                new Monster("Lion", 13, 4, 21, MonsterDificulty.Medium)
            };

            Monsters2 = new List<Monster>
            {
                new Monster("Unicorn", 14, 5, 21, MonsterDificulty.Medium),
                new Monster("Snake", 5, 3, 12, MonsterDificulty.Easy),
                new Monster("Eagle", 14, 4, 22, MonsterDificulty.Medium),
                new Monster("Ant", 8, 4, 16, MonsterDificulty.Easy),
                new Monster("Skeleton", 15, 5, 23, MonsterDificulty.Medium)
            };

            Monsters3 = new List<Monster>
            {
                new Monster("Giant", 24, 9, 28, MonsterDificulty.Hard),
                new Monster("Goblin", 13, 5, 21, MonsterDificulty.Medium),
                new Monster("Zombie", 9, 3, 14, MonsterDificulty.Easy),
                new Monster("Murloc", 8, 4, 15, MonsterDificulty.Easy),
                new Monster("Reaper", 6, 2, 10, MonsterDificulty.Easy)
            };

            Monsters4 = new List<Monster>
            {
                new Monster("Undead", 23, 8, 28, MonsterDificulty.Hard),
                new Monster("Ghost", 25, 6, 31, MonsterDificulty.Hard),
                new Monster("Ghoul", 23, 8, 30, MonsterDificulty.Hard),
                new Monster("Bat", 8, 3, 12, MonsterDificulty.Easy),
                new Monster("Orc", 14, 6, 22, MonsterDificulty.Medium)
            };

            Monsters5 = new List<Monster>
            {
                new Monster("Cyclops", 25, 10, 29, MonsterDificulty.Hard),
                new Monster("Mummy", 7, 2, 8, MonsterDificulty.Easy),
                new Monster("Demon", 16, 5, 20, MonsterDificulty.Medium),
                new Monster("Ogre", 24, 9, 28, MonsterDificulty.Hard),
                new Monster("Gnoll", 6, 3, 9, MonsterDificulty.Easy)
            };

            Monsters6 = new List<Monster>
            {
                new Monster("Werewolf", 15, 4, 20, MonsterDificulty.Medium),
                new Monster("Minotaur", 25, 8, 29, MonsterDificulty.Hard),
                new Monster("Harpy", 6, 3, 6, MonsterDificulty.Easy),
                new Monster("Scorpion", 15, 4, 21, MonsterDificulty.Medium),
                new Monster("Lich", 23, 11, 32, MonsterDificulty.Hard)
            };

            Monsters7 = new List<Monster>
            {
                new Monster("Worm", 5, 1, 6, MonsterDificulty.Easy),
                new Monster("Hydra", 14, 4, 19, MonsterDificulty.Medium),
                new Monster("Griffon", 23, 8, 29, MonsterDificulty.Hard),
                new Monster("Crab", 4, 2, 5, MonsterDificulty.Easy),
                new Monster("Amazon", 15, 3, 22, MonsterDificulty.Medium)
            };
        }
    }
}
