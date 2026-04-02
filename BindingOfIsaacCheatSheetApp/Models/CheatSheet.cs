using System;

namespace BindingOfIsaacCheatSheetApp.Models;

public class CheatSheet
{
    Object Piece { get; set; }
    string Description { get; set; }
    public CheatSheet(Object piece, string description)
    {
        this.Piece = piece;
        this.Description = description;
    }

    public static CheatSheet isaacCheatSheet = new CheatSheet(Character.isaac, "Isaac is the first character you start with, he has balanced stats and a powerful active item, the D6, that allows you to reroll item pedestals in the current room, giving you a chance to get better items.");
    public static CheatSheet magdaleneCheatSheet = new CheatSheet(Character.magdalene, "Magdalene has more health than other characters, but her active item, Yum Heart, is not as good as other characters. However, she can use it to heal herself and keep her health up.");
    public static CheatSheet cainCheatSheet = new CheatSheet(Character.cain, "Cain has a lower health than other characters, but his starting item, Lucky Foot, gives him a luck boost and converts bad pills into good pills, which can be very useful in certain situations.");
    public static CheatSheet judasCheatSheet = new CheatSheet(Character.judas, "Judas has the lowest health of all characters, but his starting item, Book of Belial, grants him a damage boost for the current room, making him a strong choice for players who want to focus on offense.");
    public static CheatSheet blueBabyCheatSheet = new CheatSheet(Character.blueBaby, "Blue Baby has no red heart containers and starts with 3 soul hearts, making him more fragile than other characters. However, his active item, The Poop, can be used to create obstacles for enemies and can be useful in certain situations.");
    public static CheatSheet eveCheatSheet = new CheatSheet(Character.eve, "Eve has a unique playstyle that revolves around taking damage to activate her powerful items. Her starting items, Whore of Babylon, Dead Bird, and Razor Blade, all grant her damage boosts when she is at low health, making her a strong choice for players who want to take risks and play aggressively.");
    public static CheatSheet[] characterCheatSheets = new CheatSheet[]
    {
        isaacCheatSheet,
        magdaleneCheatSheet,
        cainCheatSheet,
        judasCheatSheet,
        blueBabyCheatSheet,
        eveCheatSheet
    };

    public static List<Pickup> coinPickups = new()
    {
        Pickup.penny,
        Pickup.nickel,
        Pickup.dime,
        Pickup.doublePenny,
        Pickup.goldenPenny,
        Pickup.luckyPenny
    };

    public static CheatSheet coinsCheatSheet =
        new CheatSheet(coinPickups, "All coin pickups and what they do:");

    public static CheatSheet bookOfBelialCheatSheet = new(ActiveItem.bookOfBelial, "It is recomended to use it near death or to wait until you enter the boss room");
    public static CheatSheet D6CheatSheet = new(ActiveItem.D6, "It is best used in room pools with better items, Devil Deal, Angel Deal, Secret Room, Ultra Secret Room, " +
        "so try to spawn in items using beggers, devil beggers, blood donation machines in those rooms and reroll them.");
    public static CheatSheet eternalD6CheatSheet = new(ActiveItem.eternalD6, "It is best used in room pools with better items, Devil Deal, Angel Deal, Secret Room, Ultra Secret Room, " +
        "so try to spawn in items using beggers, devil beggers, blood donation machines in those rooms and reroll them. Be careful when using it, because " +
        "it has a chance to delete the item instead of rerolling it.");
    public static CheatSheet yumHeartCheatSheet = new(ActiveItem.yumHeart, "With yum heart you will rarely be at low health, so try abusing devl beggers, " +
        "sacrifice rooms and blood donation machines.");
    public static CheatSheet thePoopCheatSheet = new(ActiveItem.thePoop, "The Poop can be used to create obstacles for enemies, block projectiles, " +
        "and even create cover for yourself. It can also be used to access secret rooms by placing it on a specific tile.");
    public static CheatSheet razorBladeCheatSheet = new(ActiveItem.razorBlade, "Razor Blade is best used on Eve, since she benefits being at low healt, " +
        "also you can use it to enter curse rooms without losing soul hearts if you have any.");
    public static CheatSheet[] activeItemCheatSheets = new CheatSheet[]
    {
        bookOfBelialCheatSheet,
        D6CheatSheet,
        eternalD6CheatSheet,
        yumHeartCheatSheet,
        thePoopCheatSheet,
        razorBladeCheatSheet
    };
}
