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
}
