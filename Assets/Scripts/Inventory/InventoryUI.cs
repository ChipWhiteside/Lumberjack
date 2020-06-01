using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Transform backpackPanel;
    private Transform equipmentPickupPanel;
    private Transform characterPanel;

    private InventorySlot[] slots;
    private SheathInventorySlot[] sheathSlots;
    private EquipmentPickupInventorySlot[] equipmentSlots;

    private void Awake()
    {
        GameEvents.instance.onInvMenuPressed += InventoryPressed;   
    }

    // Start is called before the first frame update
    void Start()
    {

        GameEvents.instance.onUpdateInvUI += UpdateUI;

        backpackPanel = transform.Find("Backpack Panel");
        equipmentPickupPanel = transform.Find("Equipment Pickup Panel");
        characterPanel = transform.Find("Character Panel");

        //GameEvents.instance.onInventoryItemChanged += UpdateUI;

        //GameEvents.instance.onInventoryPressed += InventoryPressed;

        gameObject.SetActive(false);    // Sets the inventory UI to active

        slots = backpackPanel.GetComponentsInChildren<InventorySlot>();
        sheathSlots = characterPanel.GetComponentsInChildren<SheathInventorySlot>();
        equipmentSlots = equipmentPickupPanel.GetComponentsInChildren<EquipmentPickupInventorySlot>();

        //foreach (EquipmentPickupInventorySlot eslots in equipmentSlots)
        //    eslots.gameObject.SetActive(false);
        //sheathSlots[3].gameObject.SetActive(false);
        //sheathSlots[5].gameObject.SetActive(false);

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

        //Updating backpack
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < Inventory.instance.items.Count)
            {
                //slots[i].AddItem(inventory.items[i]);
                GameEvents.instance.AddInvSlot(i, Inventory.instance.items[i]);
                //GameEvents.instance.PickupItem(inventory.items[i]);
            }
            else
            {
                //slots[i].ClearSlot();
                GameEvents.instance.ClearInvSlot(i);
            }
        }
        //// Updating sheath
        //for (int i = 0; i < sheathSlots.Length; i++)
        //{
        //    if (i < inventory.sheathItems.Count)
        //    {
        //        if (i.Equals(2))
        //            sheathSlots[3].gameObject.SetActive(true);
        //        if (i.Equals(4))
        //            sheathSlots[5].gameObject.SetActive(true);
        //        sheathSlots[i].AddItem(inventory.sheathItems[i]);
        //    }
        //    else
        //    {
        //        sheathSlots[i].ClearSlot();
        //    }
        //}
        //// Updating equipment pickup
        //for (int i = 0; i < equipmentSlots.Length; i++)
        //{
        //    if (i < inventory.equipmentPickupItems.Count)
        //    {
        //        equipmentSlots[i].gameObject.SetActive(true);
        //        equipmentSlots[i].AddItem(inventory.equipmentPickupItems[i]);
        //    }
        //    else
        //    {
        //        equipmentSlots[i].ClearSlot();
        //        equipmentSlots[i].gameObject.SetActive(false);
        //    }
        //}
    }

    void InventoryPressed()
    {
        //when opened, if its because of an item, auto hover that item, otherwise hover the hands

        gameObject.SetActive(!gameObject.activeSelf);
        if (gameObject.activeSelf)
        {
            GameEvents.instance.InvMenuOpen();
        }
        else
        {
            GameEvents.instance.InvMenuClose();
            //if equipment slots isnt empty, drop all the remaining items
        }
    }
}
