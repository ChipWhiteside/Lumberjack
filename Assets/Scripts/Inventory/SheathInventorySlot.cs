using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheathInventorySlot : MonoBehaviour
{
    Item item;

    public Image icon;
    public int slotid;      // Determines which types of equipment can go in which slot

    public void Start()
    {
        GameEvents.current.onItemDropButton += OnRemoveButton;
    }

    public void AddItem(Item newItem)
    {
        item = newItem;

        if (item.name != "Placeholder Item")
        {
            icon.sprite = item.icon;
            icon.enabled = true;
        }
        else
        {
            Debug.Log("Placeholder item added to sheath inv slot " + slotid);
        }
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }

    public void OnWeaponEquipped()
    {

    }

    public void OnRemoveButton(int dropslotid)
    {
        if (dropslotid == slotid)
        {
            if (item != null)
            {
                Debug.Log(item.name + " dropped");
                Inventory.instance.RemoveItem(item);
            }
        }
    }

    public void OnEquipButton(int equipslotid)
    {
        if (equipslotid == slotid)
        {
            if (item != null)
            {
                Debug.Log(item.name + " equipped");
                Inventory.instance.EquipItem(item);

            }
        }
    }

    public void SlotSelected()
    {
        //if weapon in inventory is already selected put the weapon in the sheath slot
        //if nothing or something that is not a weapon is selected, highlight all items that can be equipped in this slot.

        //make it so weapons (that are items) have a weapontype which 0 is hip, 1 is back, 2 is chest
        //any weapontype can go in hands
        //tool can also be equiped to the back

        if (item != null)
        {
            Debug.Log("Selected " + item.name + " (slot " + slotid + " of sheath inventory)");
            Inventory.instance.invSelected = 1;
            Inventory.instance.invSlotSelected = slotid;
        }
        else
            Debug.Log("Sheath slot empty");
    }
}
