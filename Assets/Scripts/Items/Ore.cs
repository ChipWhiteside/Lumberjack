using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ore", menuName = "Inventory/Ore")]
public class Ore : Material
{
    private void Awake()
    {
        name = "New Ore";
        materialType = MaterialType.Ore;
        weightModifier = .02f;
    }

    public override void Use()
    {
        /* 
         * Weapons: use equips them and adds damage stats
         * Armor: use equips and adds weight and armor stats
         * Sheaths: open new weapon slots
         * Materials: does nothing right now
         */

        Debug.Log("Using " + name + " | Material | Ore");
    }
}
