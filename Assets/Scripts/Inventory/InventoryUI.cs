using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform backpackPanel;
    public Transform characterPanel;
    public Transform equipmentPickupPanel;
    public GameObject inventoryUI;

    Inventory inventory;

    InventorySlot[] slots;
    SheathInventorySlot[] sheathSlots;
    EquipmentPickupInventorySlot[] equipmentSlots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        GameEvents.current.onInventoryItemChanged += UpdateUI;

        GameEvents.current.onInventoryPressed += InventoryPressed;

        inventoryUI.SetActive(false);

        slots = backpackPanel.GetComponentsInChildren<InventorySlot>();
        sheathSlots = characterPanel.GetComponentsInChildren<SheathInventorySlot>();
        equipmentSlots = equipmentPickupPanel.GetComponentsInChildren<EquipmentPickupInventorySlot>();

        foreach (EquipmentPickupInventorySlot eslots in equipmentSlots)
            eslots.gameObject.SetActive(false);
        sheathSlots[3].gameObject.SetActive(false);
        sheathSlots[5].gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Inventory"))
        //{
        //    inventoryUI.SetActive(!inventoryUI.activeSelf);
        //}
        //if (inventoryUI.activeSelf)
        //{
        //    // Stop moving the player when menu opens
        //    PlayerMovement.instance.rb.velocity = Vector2.zero;
        //    PlayerAnimationController.instance.movespeed = 0.0f;

        //    if (Input.GetButtonDown("Drop"))
        //    {
        //        int invSel = Inventory.instance.inventorySelection;
        //        if (invSel >= 0 && invSel < 24)
        //            GameEvents.current.ItemDropButton(invSel);
        //    }

        //    if (Input.GetButtonDown("Equip"))
        //    {
        //        int invSel = Inventory.instance.inventorySelection;
        //        if (invSel > 0 && invSel < 24)
        //            GameEvents.current.ItemEquipButton(invSel);
        //    }
        //}
        
    }

    void UpdateUI()
    {
        Debug.Log("Updating UI");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            } else
            {
                slots[i].ClearSlot();
            }
        }

        for (int i = 0; i < sheathSlots.Length; i++)
        {
            if (i < inventory.sheathItems.Count)
            {
                if (i.Equals(2))
                    sheathSlots[3].gameObject.SetActive(true);
                if (i.Equals(4))
                    sheathSlots[5].gameObject.SetActive(true);
                sheathSlots[i].AddItem(inventory.sheathItems[i]);
            }
            else
            {
                sheathSlots[i].ClearSlot();
            }
        }

        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            if (i < inventory.equipmentPickupItems.Count)
            {
                equipmentSlots[i].gameObject.SetActive(true);
                equipmentSlots[i].AddItem(inventory.equipmentPickupItems[i]);
            }
            else
            {
                equipmentSlots[i].ClearSlot();
                equipmentSlots[i].gameObject.SetActive(false);
            }
        }
    }

    void InventoryPressed()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
        if (inventoryUI.activeSelf)
        {
            GameEvents.current.InventoryOpened();
        } else
        {
            GameEvents.current.InventoryClosed();
            //if equipment slots isnt empty, drop all the remaining items
        }
    }
}
