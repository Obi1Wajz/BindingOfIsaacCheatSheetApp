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
    static public Pickup penny = new Pickup("Penny", "Adds one coin to your total.");
    static public Pickup bomb = new Pickup("Bomb", "Adds one bomb to your total.");
    static public Pickup key = new Pickup("Key", "Adds one key to your total.");
    static public Pickup halfHeart = new Pickup("Half Heart", "Adds half a heart container to your total.");
    static public Pickup heart = new Pickup("Heart", "Adds one heart container to your total.");
    static public Pickup soulHeart = new Pickup("Soul Heart", "Adds one soul heart container to your total.");
    static public Pickup blackHeart = new Pickup("Black Heart", "Adds one black heart container to your total.");
    static public Pickup eternalHeart = new Pickup("Eternal Heart", "Adds one eternal heart container to your total when entering new floor.");
}
