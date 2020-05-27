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

    public List<Item> items = new List<Item>();
    public int maxSize = 25;

    public bool AddItem(Item item)
    {
        if (items.Count < maxSize) {
            items.Add(item);
            GameEvents.current.InventoryItemChanged();
            return true;
        } else {
            Debug.Log("Inventory full");
            return false;
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        GameEvents.current.InventoryItemChanged();
    }

}
