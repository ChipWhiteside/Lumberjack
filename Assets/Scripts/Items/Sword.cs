using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName = "Inventory/Sword")]
public class Sword : Weapon
{
    private void Awake()
    {
        name = "New Sword";
        //sheathSlot = 0;     // 0 is hip, 1 is back, 2 is chest
        //weaponType = 0;     // 0: Sword | 1: Shield | 2: Axe | 3: Longsword | 4: Battle Axe | 5: Daggers
        weaponType = WeaponType.Sword;
        equipmentSlot = EquipmentSlot.HipMain;
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

        Debug.Log("Using " + name + " | Weapon | Sword");
    }

    //public override int EquipSlot()
    //{
    //    Debug.Log("Equipping " + name);
    //    return 5; //chest, hands, back, back, hip, hip
    //}
}
