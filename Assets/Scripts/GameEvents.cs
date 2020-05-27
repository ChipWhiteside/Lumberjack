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
}
