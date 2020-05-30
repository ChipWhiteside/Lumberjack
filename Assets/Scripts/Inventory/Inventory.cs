using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of Inventory");
            return;
        }
        instance = this;
    }
    #endregion

    public int invSelected;     // The inventory the player has clicked on 0: items 1: sheathItems 2: equipmentPickupItems
    public int invSlotSelected; // The index into that array that was selected
    public Item firstSelected;

    public List<Item> items = new List<Item>();
    public int maxSize = 12;
    public List<Item> sheathItems = new List<Item>();
    public int sheathMaxSize = 6;
    public List<Item> equipmentPickupItems = new List<Item>();

    void Start()
    {
        Item placeholderItem = (Item)Item.CreateInstance("Item");
        placeholderItem.name = "Placeholder Item";
        //sheathItems = new Item[6];
        //equipmentPickupItems = new Item[1];
        //equipmentPickupItems[0] = nullItem;

        for (int i = 0; i < 6; i++)
        {
            sheathItems.Add(placeholderItem);
        }
        //Debug.Log("Sheathitems 3: " + sheathItems);
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(sheathItems[i].name);
        }
    }

    public bool AddItem(Item item)
    {
        int equipSlot = item.EquipSlot();
        if (equipSlot < 0)     // Material or other unequipable, goes into inventory
        {
            if (items.Count < maxSize)
            {
                items.Add(item);
                GameEvents.current.InventoryItemChanged();
                return true;
            }
            else
            {
                Debug.Log("Inventory full");
                return false;
            }
        } else
        {
            if (sheathItems[0].name == "Placeholder Item")      // If hands are empty put item in the hands first
                sheathItems[0] = item;
            else
            {
                equipmentPickupItems.Add(item);
                GameEvents.current.InventoryPressed();
            }
            GameEvents.current.InventoryItemChanged();
            return true;
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        GameEvents.current.InventoryItemChanged();
    }

    public void RemoveEquipment(int index) // could change this to take an item then iterate through the array looking for the item; (would have to check for doubles)
    {
        sheathItems[index] = null;
    }

    public void EquipItem(Item item)
    {
        // move the item from inventory (items) to sheath (sheathItems)
        // if any item was already in the sheath, move it to the inventory
        int equipSlot = item.EquipSlot();   // chest, hands, back, back, hip, hip
        Debug.Log("Equipment slot: " + equipSlot);
        SheathHeldEquipment();
        if (sheathItems[0] == null)
        {
            sheathItems[0] = item;
            GameEvents.current.InventoryItemChanged();
        }
    }

    public void SheathHeldEquipment()
    {
        Item toSheath = sheathItems[0];
        if (toSheath != null)
        {
            int sheathIndex = toSheath.EquipSlot();
            if (sheathItems[sheathIndex] == null)
            {
                sheathItems[sheathIndex] = toSheath;
                sheathItems[0] = null;
                GameEvents.current.InventoryItemChanged();
            } else if (sheathIndex == 2)
            {
                if (sheathItems[3] == null)
                {
                    sheathItems[sheathIndex] = toSheath;
                    sheathItems[0] = null;
                    GameEvents.current.InventoryItemChanged();
                }
            } else if (sheathIndex == 4)
            {
                if (sheathItems[5] == null)
                {
                    sheathItems[sheathIndex] = toSheath;
                    sheathItems[0] = null;
                    GameEvents.current.InventoryItemChanged();
                }
            } else
            {
                Debug.Log("Can't sheath, slots " + sheathIndex + " full");
            }
        } else
        {
            Debug.Log("No equipment to sheath");
        }
    }
}
