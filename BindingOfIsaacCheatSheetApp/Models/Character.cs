namespace BindingOfIsaacCheatSheetApp.Models
{
    public class Character
    {
        public string Name { get; set; }
        public Health StartingHealth { get; set; }
        public Item[] startingItems { get; set; }
        public Trinket startingTrinket { get; set; }
        public Pickup[] startingPickups { get; set; }
        public Object[] obtainableUnlocks { get; set; }
        public Character(string name, Health startingHealth, Item[] startingItems, 
        Trinket startingTrinket, Pickup[] startingPickups, Object[] obtainableUnlocks)
        {
            this.Name = name;
            this.StartingHealth = startingHealth;
            this.startingItems = startingItems;
            this.startingTrinket = startingTrinket;
            this.startingPickups = startingPickups;
            this.obtainableUnlocks = obtainableUnlocks;
        } 
    }
}