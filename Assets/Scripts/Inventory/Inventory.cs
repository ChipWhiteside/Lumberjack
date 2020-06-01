using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    private int invMax = 12;

    public static Inventory instance;
    private PlayerInputActions actions;
    //private GameObject itemSlotSelected;
    private int invSlotSelected;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of Inventory");
            return;
        }
        instance = this;

        actions = new PlayerInputActions();

        //actions.Inventory.Select.performed += ctx => Select();
        actions.Inventory.Drop.performed += ctx => Drop();
        actions.Inventory.Swap.performed += ctx => Swap();
        actions.Inventory.Cancel.performed += ctx => Cancel();
        actions.Inventory.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }

    private void Start()
    {
        //itemSlotSelected = null;
        invSlotSelected = 0;

        GameEvents.instance.onPickupItem += Add;
        GameEvents.instance.onInvMenuOpen += enableInvMenu;
        GameEvents.instance.onInvMenuClose += disableInvMenu;
        GameEvents.instance.onInvSlotSelect += Select;
    }

    void enableInvMenu()
    {
        actions.Enable();
    }

    void disableInvMenu()
    {
        actions.Disable();
    }

    //private void OnEnable()
    //{
    //    actions.Enable();
    //}

    //private void OnDisable()
    //{
    //    actions.Disable();
    //}

    private void Add(Item item)
    {
        //check whic inventory it goes into

        if (items.Count >= invMax)
        {
            Debug.Log("Not enough space");
            GameEvents.instance.PickupItemFail();
            return;
        }

        items.Add(item);
        GameEvents.instance.PickupItemSuccess();
        GameEvents.instance.UpdateInvUI();
    }

    private void Remove(Item item)
    {

    }

    void Select(int slotIdSelected)
    {
        invSlotSelected = slotIdSelected;
        Debug.Log("Selected slot " + invSlotSelected);

        //RaycastMouse();
    }

    void Drop()
    {
        Debug.Log("Drop pressed");
    }

    void Swap()
    {
        Debug.Log("Swap pressed");
    }

    void Cancel()
    {
        Debug.Log("Cancel pressed");
        GameEvents.instance.InvMenuPressed();
    }

    void Move(Vector2 movement)
    {
        //if (itemSlotSelected == null)
        //    return;

        //if (movement.x > 0)
        //{
        //    Debug.Log("Right: " + itemSlotSelected.GetComponent<Button>().navigation.selectOnRight.gameObject.name);
        //}
        //else if (movement.x < 0)
        //{
        //    Debug.Log("Left: " + itemSlotSelected.GetComponent<Button>().navigation.selectOnLeft.gameObject.name);
        //}
        //else if (movement.y > 0)
        //{
        //    Debug.Log("Up: " + itemSlotSelected.GetComponent<Button>().navigation.selectOnUp.gameObject.name);
        //}
        //else if (movement.y < 0)
        //{
        //    //Debug.Log("Down pressed");
        //    //Debug.Log("Slot selected: " + itemSlotSelected.name);
        //    //Button b = itemSlotSelected.GetComponent<Button>();
        //    //Debug.Log("Button: " + b);
        //    //Selectable s = b.navigation.selectOnDown.;
        //    //Debug.Log("Selectable: " + s);
        //    //string n = s.gameObject.name;
        //    //Debug.Log("Name: " + n);
        //}
    }

    void MouseOver()
    {
        //    if (EventSystem.current.IsPointerOverGameObject())
        //    {
        //        Debug.Log(EventSystem.current.);
        //    }


        //RaycastHit2D hit;

        //Ray ray = Camera.main.ScreenPointToRay((Vector3) Mouse.current.position.ReadValue());
        //if (hit = Physics2D.Raycast(ray.origin, new Vector2(0, 0)))
        //    Debug.Log(hit.collider.name);
    }

    //public List<RaycastResult> RaycastMouse()
    //{

    //    PointerEventData pointerData = new PointerEventData(EventSystem.current)
    //    {
    //        pointerId = -1,
    //    };

    //    pointerData.position = Mouse.current.position.ReadValue(); //Camera.main.ScreenToWorldPoint(Mouse.current.position);//Input.mousePosition;

    //    List<RaycastResult> results = new List<RaycastResult>();
    //    EventSystem.current.RaycastAll(pointerData, results);

    //    Debug.Log(results.Count);

    //    GameObject itemSlot = null;

    //    for (int i = 0; i < results.Count; i++)
    //    {
    //        Debug.Log(i + ": " + results[i]);
    //        if (results[i].gameObject.name == "ItemSlot")
    //        {
    //            itemSlot = results[i].gameObject;
    //        }
    //    }

    //    //itemSlotSelected = itemSlot;


    //    InventorySlot parentOfClicked = itemSlot.GetComponentInParent<InventorySlot>();

    //    Debug.Log("Name: " + parentOfClicked.name + " | id: " + parentOfClicked.GetComponent<InventorySlot>().slotid);

    //    return results;
    //}

    //    /*
    //     * Notes:
    //     * 
    //     * Have the player manually have to pickup items on the ground?
    //     * 
    //     * Create a bool, pickupable which if its true, puts the item in the inventory, 
    //     * if not, puts the item in the equipment pickup inventory and makes the player 
    //     * choose where to put it.
    //     * This way if the player picks up a material and there is still inventory space
    //     * it puts it right in the inventory, if not, it goes into the EP inventory and they
    //     * must choose what to drop to add it.
    //     * Equipment like weapons and tools also auto go into EP inventory.
    //     * 
    //     */

    //    #region Singleton
    //    public static Inventory instance;

    //    private void Awake()
    //    {
    //        if (instance != null)
    //        {
    //            Debug.Log("More than one instance of Inventory");
    //            return;
    //        }
    //        instance = this;
    //    }
    //    #endregion

    //    public int invHovered;     // The inventory the player has hovered on 0: items 1: sheathItems 2: equipmentPickupItems
    //    public int invSlotHovered; // The index into that array that was hovered
    //    public Item itemHovered;

    //    public int invSelected;       // The inventory the player has clicked on 0: items 1: sheathItems 2: equipmentPickupItems
    //    public int invSlotSelected;   // The index into that array that was selected
    //    public Item itemSelected;

    //    public Item firstSelected;
    //    public bool swapStarted = false;

    //    public List<Item> items = new List<Item>();
    //    public int maxSize = 12;
    //    public List<Item> sheathItems = new List<Item>();
    //    public int sheathMaxSize = 6;
    //    public List<Item> equipmentPickupItems = new List<Item>();

    //    public List<Item>[] lists = new List<Item>[3];

    //    void Start()
    //    {
    //        //Item placeholderItem = (Item)Item.CreateInstance("Item");
    //        //placeholderItem.name = "Placeholder Item";
    //        //sheathItems = new Item[6];
    //        //equipmentPickupItems = new Item[1];
    //        //equipmentPickupItems[0] = nullItem;

    //        //for (int i = 0; i < 6; i++)
    //        //{
    //        //    sheathItems.Add(placeholderItem);
    //        //}
    //        //Debug.Log("Sheathitems 3: " + sheathItems);
    //        //for (int i = 0; i < 6; i++)
    //        //{
    //        //    Debug.Log(sheathItems[i].name);
    //        //}

    //        lists = new List<Item>[] { items, sheathItems, equipmentPickupItems };
    //    }

    //    public bool Add(Item item)
    //    {
    //        //int equipSlot = item.EquipSlot();
    //        //if (equipSlot < 0)     // Material or other unequipable, goes into inventory
    //        //{
    //        //    if (items.Count < maxSize)
    //        //    {
    //        //        items.Add(item);
    //        //        GameEvents.current.InventoryItemChanged();
    //        //        return true;
    //        //    }
    //        //    else
    //        //    {
    //        //        Debug.Log("Inventory full");
    //        //        return false;
    //        //    }
    //        //} else
    //        //{
    //        //    if (sheathItems[0] == null)      // If hands are empty put item in the hands first
    //        //        sheathItems[0] = item;
    //        //    else
    //        //    {
    //        //        equipmentPickupItems.Add(item);
    //        //        GameEvents.current.InventoryPressed();
    //        //    }
    //        //    GameEvents.current.InventoryItemChanged();
    //        //    return true;
    //        //}
    //        items.Add(item);
    //        GameEvents.current.InventoryItemChanged();
    //        return true;
    //    }

    //    public void Remove(Item item)
    //    {
    //        items.Remove(item);
    //        GameEvents.current.InventoryItemChanged();
    //    }

    //    public void RemoveEquipment(int index) // could change this to take an item then iterate through the array looking for the item; (would have to check for doubles)
    //    {
    //        sheathItems[index] = null;
    //    }

    //    public void EquipItem(Item item)
    //    {
    //        // move the item from inventory (items) to sheath (sheathItems)
    //        // if any item was already in the sheath, move it to the inventory
    //        int equipSlot = item.EquipSlot();   // chest, hands, back, back, hip, hip
    //        Debug.Log("Equipment slot: " + equipSlot);
    //        SheathHeldEquipment();
    //        if (sheathItems[0] == null)
    //        {
    //            sheathItems[0] = item;
    //            GameEvents.current.InventoryItemChanged();
    //        }
    //    }

    //    public void OnActionButton(int actionId)
    //    {
    //        /* 
    //         * 0: Select
    //         * 1: Drop
    //         * 2: Swap
    //         * 3: Cancel
    //         */
    //        switch (actionId)
    //        {
    //            case 0:
    //                invSelected = invHovered;
    //                invSlotSelected = invSlotHovered;
    //                Debug.Log("Selected slot " + invSlotSelected + " in inventory " + invSelected);
    //                break;
    //            case 1:
    //                SpawnItem(Player.instance.transform.position + (Vector3)(Player.instance.directionFacing * 2), itemHovered);
    //                //lists[invHovered].RemoveAt(invSlotHovered);
    //                lists[invHovered].Remove(itemHovered);
    //                GameEvents.current.InventoryItemChanged();
    //                Debug.Log("Dropped slot " + invSlotHovered + " in inventory " + invHovered);

    //                //switch (invHovered)
    //                //{
    //                //    case 0:
    //                //        SpawnItem(Player.instance.transform.position + (Vector3) Player.instance.directionFacing, items[invSlotHovered]);
    //                //        items.RemoveAt(invSlotHovered);
    //                //        GameEvents.current.InventoryItemChanged();
    //                //        Debug.Log("Dropped slot " + invSlotHovered + " in inventory " + invHovered);
    //                //        break;
    //                //    case 1:
    //                //        sheathItems.RemoveAt(invSlotHovered);
    //                //        break;
    //                //    case 2:
    //                //        equipmentPickupItems.RemoveAt(invSlotHovered);
    //                //        break;
    //                //    default:
    //                //        break;
    //                //}
    //                break;
    //            case 2:

    //                break;
    //            case 3:

    //                break;
    //            default:
    //                break;
    //        }
    //    }

    //    public void SpawnItem(Vector3 pos, Item item)
    //    {
    //        GameObject newObject = new GameObject();
    //        newObject.AddComponent<ItemManager>();
    //        newObject.GetComponent<ItemManager>().item = item;
    //        newObject.GetComponent<ItemManager>().SetupItem();
    //        Instantiate(newObject, pos, Quaternion.identity);
    //    }

    //    public void StartedTrade()
    //    {
    //        Debug.Log("Trade started");
    //    }

    //    public void SheathHeldEquipment()
    //    {
    //        Item toSheath = sheathItems[0];
    //        if (toSheath != null)
    //        {
    //            int sheathIndex = toSheath.EquipSlot();
    //            if (sheathItems[sheathIndex] == null)
    //            {
    //                sheathItems[sheathIndex] = toSheath;
    //                sheathItems[0] = null;
    //                GameEvents.current.InventoryItemChanged();
    //            } else if (sheathIndex == 2)
    //            {
    //                if (sheathItems[3] == null)
    //                {
    //                    sheathItems[sheathIndex] = toSheath;
    //                    sheathItems[0] = null;
    //                    GameEvents.current.InventoryItemChanged();
    //                }
    //            } else if (sheathIndex == 4)
    //            {
    //                if (sheathItems[5] == null)
    //                {
    //                    sheathItems[sheathIndex] = toSheath;
    //                    sheathItems[0] = null;
    //                    GameEvents.current.InventoryItemChanged();
    //                }
    //            } else
    //            {
    //                Debug.Log("Can't sheath, slots " + sheathIndex + " full");
    //            }
    //        } else
    //        {
    //            Debug.Log("No equipment to sheath");
    //        }
    //    }
}
