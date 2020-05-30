using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{

    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onTreeGrow;
    public void GrowTrees()
    {
        if (onTreeGrow != null)
        {
            onTreeGrow();
        }
    }

    //public event Action<int> onChopTree;
    //public void ChopTree(int treeid)
    //{
    //    if (onChopTree != null)
    //    {
    //        onChopTree(treeid);
    //    }
    //}

    public event Action<int> onActionButtonPressed;
    public void ActionButtonPressed(int toolid)
    {
        if (onActionButtonPressed != null)
        {
            onActionButtonPressed(toolid);
        }
    }

    public event Action onInventoryItemChanged;
    public void InventoryItemChanged()
    {
        if (onInventoryItemChanged != null)
        {
            onInventoryItemChanged();
        }
    }

    public event Action<int> onItemDropButton;
    public void ItemDropButton(int slotToDrop)
    {
        if (onItemDropButton != null)
        {
            onItemDropButton(slotToDrop);
        }
    }

    public event Action<int> onItemEquipButton;
    public void ItemEquipButton(int slotToEquip)
    {
        if (onItemEquipButton != null)
        {
            onItemEquipButton(slotToEquip);
        }
    }

    public event Action onInventoryPressed;
    public void InventoryPressed()
    {
        if (onInventoryPressed != null)
        {
            onInventoryPressed();
        }
    }

    public event Action onInventoryOpened;
    public void InventoryOpened()
    {
        if (onInventoryOpened != null)
        {
            onInventoryOpened();
        }
    }

    public event Action onInventoryClosed;
    public void InventoryClosed()
    {
        if (onInventoryClosed != null)
        {
            onInventoryClosed();
        }
    }

    public event Action onStartPressed;
    public void StartPressed()
    {
        if (onStartPressed != null)
        {
            onStartPressed();
        }
    }

    public event Action onStartOpened;
    public void StartOpened()
    {
        if (onStartOpened != null)
        {
            onStartOpened();
        }
    }

    public event Action onStartClosed;
    public void StartClosed()
    {
        if (onStartClosed != null)
        {
            onStartClosed();
        }
    }

    public event Action onDropItem;
    public void DropItem()
    {
        if (onDropItem != null)
        {
            onDropItem();
        }
    }
}
