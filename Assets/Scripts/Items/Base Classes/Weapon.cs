using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipment
{
    //public int weaponType;      // 0: Sword | 1: Shield | 2: Axe | 3: Longsword | 4: Battle Axe | 5: Daggers
    public WeaponType weaponType;
}

public enum WeaponType { Sword, Shield, Axe, Longsword, BattleAxe, Daggers }
