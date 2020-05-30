using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item
{
    public EquipmentSlot equipmentSlot;

    public float damageModifier;
}

public enum EquipmentSlot { Hands, Chest, HipMain, HipSecondary, BackMain, BackSecondary }