namespace TextRPG
{
    public enum ItemType
    {
        Consumable = 0,
        Weapon = 1,
        Valuables = 2,
        Armor = 3,
    };

    public struct Item
    {
        public string name;
        public int value;
        public ItemType Type;
        public int Modifier;
    };
}

