namespace OOP_RPG
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Price { get; set; }

        public Weapon(string name, int strength, int price)
        {
            Name = name;
            Strength = strength;
            Price = price;
        }
    }
}