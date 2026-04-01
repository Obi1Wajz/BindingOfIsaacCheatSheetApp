using System;

namespace BindingOfIsaacCheatSheetApp.Models;

public class Trinket
{
    string Name { get; set; }
    string Description { get; set; }

    public Trinket(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    static public Trinket paperClip = new Trinket("Paper Clip", "Opens golden chests for free.");
    static public Trinket childsHeart = new Trinket("Child's Heart", "Chance for more heart drops.");
}
