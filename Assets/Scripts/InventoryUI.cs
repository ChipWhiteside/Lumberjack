﻿using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        GameEvents.current.onInventoryItemChanged += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {

    }
}
