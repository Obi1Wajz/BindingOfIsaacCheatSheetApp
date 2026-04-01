using System;

namespace BindingOfIsaacCheatSheetApp.Models;
public class ActiveItem : Item
{
    public string? ActiveEffect { get; set; }
    public int MaxCharges { get; set; }
    public int UsageTimes { get; set; }

    public ActiveItem(string name, string? passiveEffect, string? activeEffect, int maxCharges, int usageTimes) : base(name, passiveEffect)
    {
        this.ActiveEffect = activeEffect;
        this.MaxCharges = maxCharges;
        this.UsageTimes = usageTimes;
    }

    public override string ToString()
    {
        if(UsageTimes==-1)
            return $"Name: {Name}, Passive Effect: {PassiveEffect ?? "None"}, Active Effect: {ActiveEffect}, Max Charges: {MaxCharges}, Usage Times: Infinite";
        if (UsageTimes == -1)
            return $"Name: {Name}, Passive Effect: {PassiveEffect ?? "None"}, Active Effect: {ActiveEffect}, Max Charges: {MaxCharges}, Usage Times: Infinite";
        return $"Name: {Name}, Passive Effect: {PassiveEffect}, Active Effect: {ActiveEffect ?? "None"}, Max Charges: {MaxCharges}, Usage Times: {UsageTimes}";
    }

    public static ActiveItem bookOfBelial = new ActiveItem("Book of Belial", null, "Grants +2 damage for the current room.", 3, infinite);
    public static ActiveItem D6 = new ActiveItem("D6", null, "Rerolls item pedestal into current item pool.", 6, infinite);
    public static ActiveItem eternalD6 = new ActiveItem("Eternal D6", null, "Rerolls item pedestal into current item pool, has chance to delete it instead.", 2, infinite);
    public static ActiveItem yumHeart = new ActiveItem("YumHeart", null, "Heals 1 Red Haert.", 4, infinite);
    public static ActiveItem thePoop = new ActiveItem("The Poop", null, "Spawns 1 poop on the tile Isaac is standing on.", 1, infinite);
    public static ActiveItem razorBlade = new ActiveItem("Razor Blade", null, "Damages Isaac, grants +1.2 damage for the current room.", 1, infinite);
    public static ActiveItem boxOfFriend = new ActiveItem("Box of Friends", null, "Duplicates all familiars in the room.", 4, infinite);
    public static ActiveItem woodenNickel = new ActiveItem("woodenNickel", null, "Has a chance to drop random coin.", 1, infinite);
    public static ActiveItem voidVoid = new ActiveItem("Void", null, "Erases all item pedastals in room, adds stat boosts for erase passive items, absorbs effect of active items.", 4, infinite);

    static int infinite = -1;
    static int once_per_floor = 0;
}

