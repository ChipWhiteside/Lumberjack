using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Axe", menuName = "Inventory/Axe")]
public class Axe : Tool
{
    private void Awake()
    {
        name = "New Axe";
        toolType = ToolType.Axe;
        weightModifier = 1.0f;
    }

    public override void Use()
    {
        /* 
         * Weapons: use equips them and adds damage stats
         * Armor: use equips and adds weight and armor stats
         * Sheaths: open new weapon slots
         * Materials: does nothing right now
         */

        Debug.Log("Using " + name + " | Tool | Axe");
    }

    //public override int Equip()
    //{
    //    Debug.Log("Equipping " + name);
    //    return 2; //chest, hands, back, back, hip, hip
    //}
}
