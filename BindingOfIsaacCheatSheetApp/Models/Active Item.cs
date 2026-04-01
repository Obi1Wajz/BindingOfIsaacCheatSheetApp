using System;

namespace BindingOfIsaacCheatSheetApp.Models;

public class ActiveItem : Item
{
    public int MaxCharges { get; set; }
    public int UsageTimes { get; set; }
    public int OnUseEffect { get; set; }

    public ActiveItem(string name, string description, int maxCharges, int usageTimes) : base(name, description)
    {
        this.MaxCharges = maxCharges;
        this.UsageTimes = usageTimes;
    }
}
