using System;

namespace BindingOfIsaacCheatSheetApp.Models;

public class Item
{
    public string Name { get; set; }
    public string PassiveEffect { get; set; }

    public Item(string name, string passiveEffect)
    {
        this.Name = name;
        this.PassiveEffect = passiveEffect;
    }

    public static Item bloodyLust = new Item("Bloody Lust", "Grants damage per hits, the damage boosts last for the rest of the floor.");
    public static Item whoreOfBabylon = new Item("Whore of Babylon", "Grants +1.5 damage, +0.3 speed if youre at half red heart or less, 1 red heart or less for Eve.");
    public static Item deadBird = new Item("Dead Bird", "Spawns a friendly bird that attacks enemies when you take damage, 4 damage per second");
    public static Item luckyFoot = new Item("Lucky Foor", "Grants +1 luck, converts bad pills into good pills.");
    public static Item brimstone = new Item("Brimstone", "Replaces tears with a blood laser that you charge up before fireing.");
    public static Item anemic = new Item("Anemic", "Isaac leaves a trail of creep behind him for the rest of the floor.");
    public static Item holyMantle = new Item("Holy Mantle", "Grants a shield that blocks the first damage you would take in each room.");
    public static Item incubus = new Item("Incubus", "Demonic familiar dealing 0.75x Isaac's damage.");
    public static Item bookOfVirtues = new Item("Book of Virtues", "Grants an active item, than can be used in combination with another, grants wisp familiars, converts first devil deal into angel deal.");
}
