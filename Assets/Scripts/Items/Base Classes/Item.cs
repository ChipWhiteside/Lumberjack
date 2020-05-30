using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public float itemRadius = 1f;
    //public int itemID = 0;
    public float weightModifier = 0;
    public Sprite icon = null;

    public virtual void Use()
    {
        /* 
         * Weapons: use equips them and adds damage stats
         * Armor: use equips and adds weight and armor stats
         * Sheaths: open new weapon slots
         * Materials: does nothing right now
         */

        Debug.Log("Using " + name);
    }

    public bool PickupSuccessful()
    {
        return true;
    }

    public virtual int EquipSlot()
    {
        return -1;
    }
}
