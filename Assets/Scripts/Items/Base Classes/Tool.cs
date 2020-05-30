using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : Equipment
{
    private void Awake()
    {
        equipmentSlot = EquipmentSlot.BackMain;
    }
    public ToolType toolType;

    public override int EquipSlot()
    {
        return 2; //chest, hands, back, back, hip, hip
    }
}

public enum ToolType { Axe, Pickaxe }
