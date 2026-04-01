using System;

namespace BindingOfIsaacCheatSheetApp.Models;

public class Health
{
    public EHealthType HealthType { get; set; }
    public int Amount { get; set; }

    public Health(EHealthType healthType, int amount)
    {
        this.HealthType = healthType;
        this.Amount = amount;
    }
}
