using System;

namespace BindingOfIsaacCheatSheetApp.Models;

public class CheatSheet
{
    Character Character { get; set; }
    string Description { get; set; }
     public CheatSheet(Character character, string description)
    {
        this.Character = character;
        this.Description = description;
    }   
}
