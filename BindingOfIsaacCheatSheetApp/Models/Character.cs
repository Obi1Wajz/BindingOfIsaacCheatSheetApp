namespace BindingOfIsaacCheatSheetApp.Models
{
    public class Character
    {
        public string Name { get; set; }
        public Health StartingHealth { get; set; }
        public List<Item> startingItems { get; set; }
        public Trinket? startingTrinket { get; set; }
        public List<Pickup> startingPickups { get; set; }
        public List<Object> obtainableUnlocks { get; set; }
        public Character(string name, Health startingHealth, Item[] startingItems, 
        Trinket? startingTrinket, Pickup[] startingPickups, Object[] obtainableUnlocks)
        {
            this.Name = name;
            this.StartingHealth = startingHealth;
            this.startingItems = new List<Item>(startingItems);
            this.startingTrinket = startingTrinket;
            this.startingPickups = new List<Pickup>(startingPickups);
            this.obtainableUnlocks = new List<Object>(obtainableUnlocks);
        } 

        public static Character isaac = new Character("Isaac", new Health(EHealthType.RedHearts, 3), 
            new Item[] {ActiveItem.D6}, null, new Pickup[] { Pickup.bomb}, new Object[] { });
        public static Character magdalene = new Character("Magdalene", new Health(EHealthType.RedHearts, 4),
            new Item[] { ActiveItem.yumHeart }, null, new Pickup[] { Pickup.FullHealthPill }, new Object[] { });
        public static Character cain = new Character("Cain", new Health(EHealthType.RedHearts, 2), 
            new Item[] { Item.luckyFoot }, null, new Pickup[] { Pickup.key }, new Object[] { });
        public static Character judas = new Character("Judas", new Health(EHealthType.RedHearts, 1), 
            new Item[] { ActiveItem.bookOfBelial }, null, new Pickup[] { Pickup.penny, Pickup.penny, Pickup.penny }, new Object[] { });
        public static Character blueBaby = new Character("???", new Health(EHealthType.SoulHearts, 3), 
            new Item[] { ActiveItem.thePoop }, null, new Pickup[] { }, new Object[] { });
        public static Character eve = new Character("Eve", new Health(EHealthType.RedHearts, 2), 
            new Item[] { Item.whoreOfBabylon, Item.deadBird, ActiveItem.razorBlade }, null, new Pickup[] { Pickup.penny, Pickup.penny }, new Object[] { });


    }
}