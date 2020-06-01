using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Item item;

    public Image icon;
    public int slotid;

    public void Start()
    {
        GameEvents.instance.onClearInvSlot += ClearSlot;
        GameEvents.instance.onAddInvSlot += AddItem;
        //GameEvents.instance.onInvSlotDrop += OnRemoveButton;
        //GameEvents.instance.onInvSlotSelect += OnEquipButton;
    }

    public void AddItem(int slotToAddAt, Item newItem)
    {
        if (slotToAddAt.Equals(slotid))
        {
            item = newItem;
            //if (item.name != "Placeholder Item")
            //{
            icon.sprite = item.icon;
            icon.enabled = true;

            //GameEvents.instance.UpdateInvUI();
        }
        else
        {
            Debug.Log("Placeholder item added to inventory slot " + slotid);
        }
        
    }

    public void ClearSlot(int slotToClear)
    {
        if (slotid.Equals(slotToClear))
        {
            item = null;

            icon.sprite = null;
            icon.enabled = false;

            //GameEvents.instance.UpdateInvUI();
        }
    }

    public void Selected()
    {
        GameEvents.instance.InvSlotSelect(slotid);
    }
    //public void OnRemoveButton(int dropslotid)
    //{
    //    if (dropslotid.Equals(slotid))
    //    {
    //        if (item != null)
    //        {
    //            Debug.Log(item.name + " dropped");
    //            //Inventory.instance.RemoveItem(item);
    //        }
    //    }
    //}

    //public void OnEquipButton(int equipslotid)
    //{
    //    if (equipslotid.Equals(slotid))
    //    {
    //        if (item != null)
    //        {
    //            Debug.Log(item.name + " equipped");
    //            //Inventory.instance.EquipItem(item);
    //        }
    //    }
    //}

    //public void SlotHovered()
    //{
    //    if (item != null)
    //    {
    //        Debug.Log("Selected " + item.name + " (slot " + slotid + " of backpack)");
    //        Inventory.instance.invSelected = 0;
    //        Inventory.instance.invSlotSelected = slotid;
    //        Inventory.instance.itemSelected = item;
    //    }
    //    else
    //        Debug.Log("Packpack slot empty");
    //}

    //public void StartedHover()
    //{
    //    if (item != null)
    //    {
    //        Debug.Log("Selected " + item.name + " (slot " + slotid + " of backpack)");
    //        //Inventory.instance.invHovered = 0;
    //        //Inventory.instance.invSlotHovered = slotid;
    //        //Inventory.instance.itemHovered = item;
    //    }
    //        else
    //            Debug.Log("Packpack slot empty");
    //}

    //public void StoppedHover()
    //{
    //    Debug.Log("Stopped hover on backpack slot " + slotid);
    //}
}
