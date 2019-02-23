namespace OOP_RPG
{
    public class Armor
    {
        public string Name { get; set; }
        public int Defense { get; set; }
        public int Price { get; set; }

        public Armor(string name, int defense, int price)
        {
            Name = name;
            Defense = defense;
            Price = price;
        }
    }
}