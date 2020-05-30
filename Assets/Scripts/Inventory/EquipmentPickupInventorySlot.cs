using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentPickupInventorySlot : MonoBehaviour
{
    Item item;

    public Image icon;
    public int slotid;

    public void Start()
    {
        GameEvents.current.onItemDropButton += OnRemoveButton;
        GameEvents.current.onItemEquipButton += OnEquipButton;
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
            Debug.Log("Placeholder item added to equipment pickup slot " + slotid);
        }
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
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
        if (item != null)
        {
            Debug.Log("Selected " + item.name + " (slot " + slotid + " of equipment pickup inv.)");
            Inventory.instance.invSelected = 2;
            Inventory.instance.invSlotSelected = slotid;
        }
        else
            Debug.Log("Equipment pickup slot empty");
    }
}
