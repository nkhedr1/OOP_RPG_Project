using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Monster
    {
        public enum Difficulty {Easy, Medium, Hard};
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }    
        public Difficulty MonsterDifficulty { get; set; }
       

        public Monster(string name, int strength, int defense, int hp, Difficulty difficulty)
        {
            Name = name;
            Strength = strength;
            Defense = defense;
            OriginalHP = hp;
            CurrentHP = hp;
            MonsterDifficulty = difficulty;
        }

       

    }
}