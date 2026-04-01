using System;

namespace BindingOfIsaacCheatSheetApp.Models;

public class Pickup
{
    string Name { get; set; }
    string Description { get; set; }

    public Pickup(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }
    static public Pickup penny = new Pickup("Penny", "Adds 1 coin to your total.");
    static public Pickup nickel = new Pickup("Nickel", "Adds 5 coins to your total.");
    static public Pickup dime = new Pickup("Dime", "Adds 10 coins to your total.");
    static public Pickup doublePenny = new Pickup("Penny", "Adds 2 coins to your total.");
    static public Pickup goldenPenny = new Pickup("Golden Penny", "Adds 1 coin to your total, has chance to respawn in a random spot in room.");
    static public Pickup luckyPenny = new Pickup("Penny", "Adds 1 coin to your total, adds +1 luck stat boost."); 

    static public Pickup bomb = new Pickup("Bomb", "Adds 1 bomb to your total.");
    static public Pickup doubleBomb = new Pickup("Double Bomb", "Adds 2 bombs to your total.");
    static public Pickup goldenBomb = new Pickup("Golden Bomb", "Turns bomb indicator golden for the rest of the floor, you can use infinite bombs for the rest of the floor.");
    static public Pickup trollBomb = new Pickup("Troll Bomb", "Cannot be picked up, blows up and damages player if in range.");
    static public Pickup megaTrollBomb = new Pickup("Mega Troll Bomb", "Cannot be picked up, blows up and damages player if in range, also chases player in the room.");
    static public Pickup goldenTrollBomb = new Pickup("Golden Troll Bomb", "Acts like troll bomb, but doesn't dissapear after blowing up.");
    static public Pickup gigaBomb = new Pickup("Giga Bomb", "Normally cannot be picked up, dropped by Bombgaggers and Ultra War, explodes and destroyes tiles bellow it.");
    static public Pickup throwableBomb = new Pickup("Throwable Bomb", "Becomes active immediately uppon pickup, throw it before it blows up.");

    static public Pickup key = new Pickup("Key", "Adds one key to your total.");
    static public Pickup keyRing = new Pickup("Key", "Adds 2 key to your total.");
    static public Pickup goldenKey = new Pickup("Golden Key", "Turns key indicator golden for the rest of the floor, you can use infinite keys for the rest of the floor.");
    static public Pickup chargedKey = new Pickup("Charged Key", "Adds one key to your total, and fully charges active item.");

    static public Pickup halfHeart = new Pickup("Half Heart", "Adds 1/2 a heart  to your total.");
    static public Pickup heart = new Pickup("Heart", "Adds 1 heart  to your total.");
    static public Pickup Scaredheart = new Pickup("Heart", "Adds 1 heart to your total, runs from player.");
    static public Pickup soulHeart = new Pickup("Soul Heart", "Adds 1 soul heart to your total.");
    static public Pickup halfSoulHeart = new Pickup("Half Soul Heart", "Adds 1/2 soul hearts to your total.");
    static public Pickup Blendedheart = new Pickup("Blended Heart", "Adds 1 heart to your total, if you are missing 1/2 heart, adds 1/2 heart, 1/2 soul hearts, if read hearts are full acts as soul heart.");
    static public Pickup blackHeart = new Pickup("Black Heart", "Adds 1 black heart to your total or if you have full hearts converts soul heart to black heart, when broken deals 40 damage to all enemies in room.");
    static public Pickup eternalHeart = new Pickup("Eternal Heart", "Adds 1 eternal heart container to your total when entering new floor.");
    static public Pickup goldHeart = new Pickup("Gold Heart", "Adds 1 golden heart outline to your last heart, when that heart is empty it breaks into coins, and temporarily turns enemy that broke it by contact into gold.");
    static public Pickup boneHeart = new Pickup("Bone Heart", "Adds 1 bone heart  to your total, if the character can pickup red hearts, it gets filled with it.");
    static public Pickup rottenHeart = new Pickup("Rotten Heart", "Adds 1 rotten heart  to your total, but it gets depleted in 1 hit, if heart containers are filled, it replaces the last red heart.s");
    
    static public Pickup FullHealthPill = new Pickup("Full Health Pill", "Fully heals your red heart containers.");
}
