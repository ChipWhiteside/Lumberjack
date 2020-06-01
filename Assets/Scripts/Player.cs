using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions controls;
    private Rigidbody2D rb;
    private float speed = 7f;

    private Vector2 movementInput = Vector2.zero;
    private Vector2 directionFacing = Vector2.zero;
    //private bool menuOpen;

    private void Awake()
    {
        //instance = this;

        controls = new PlayerInputActions();
        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controls.Player.Movement.canceled += context => MoveCancelled(context.ReadValue<Vector2>());

        controls.Player.Inventory.performed += ctx => Inventory();


        //controls.Player.Movement.performed += context => Move(context.ReadValue<Vector2>());

        //        controls.Player.Select.performed += context => InventoryItemAction(0);      // Select
        //        controls.Player.Drop.performed += context => InventoryItemAction(1);        // Drop
        //        controls.Player.Swap.performed += context => InventoryItemAction(2);        // Swap
        //        controls.Player.Cancel.performed += context => InventoryItemAction(3);      // Cancel

        //        controls.Player.StartMenu.performed += context => StartMenu();
        //        controls.Player.Inventory.performed += context => InventoryButton();
        //        controls.Player.Sprint.performed += context => speed = 10.0f;
        //        controls.Player.Sprint.canceled += context => speed = 7f;
        //        //controls.Player.Movement.performed += context => directionFacing = context.ReadValue<Vector2>();
        //controls.Player.Movement.canceled += context => directionFacing = context.ReadValue<Vector2>();

        //        invMenuOpen = false;
        //        startMenuOpen = false;
        //        manipulatingItem = false;
    }

    private void Start()
    {
        //menuOpen = false;

        rb = GetComponent<Rigidbody2D>();

        //GameEvents.instance.onInvMenuOpen += OnMenuOpen;
        //GameEvents.instance.onStartMenuOpen += OnMenuOpen;
        //GameEvents.instance.onInvMenuClose += OnMenuClose;
        //GameEvents.instance.onStartMenuClose += OnMenuClose;

        GameEvents.instance.onInvMenuOpen += OnDisable;
        GameEvents.instance.onInvMenuClose += OnEnable;
    }

    private void Update()
    {
        //        //Debug.Log("movementInput" + movementInput);
        //        //Debug.Log("directionFacing" + directionFacing);


        rb.velocity = movementInput * speed;
        PlayerAnimationController.instance.dirFacing = directionFacing;
        PlayerAnimationController.instance.dirMoving = movementInput;

        //        //if (movementInput != Vector2.zero)
        //        //{
        //        //    Move();
        //        //}
        //        //Debug.Log("Speed" + speed);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void EnableActions()
    {
        controls.Enable();
    }

    void DisableActions()
    {
        controls.Disable();
    }

    void Move(Vector2 movement)
    {
        Debug.Log("Moving + " + movement);
        movementInput = movement;
        directionFacing = movement;
    }

    void MoveCancelled(Vector2 movement)
    {
        movementInput = movement;
    }

    void Inventory()
    {
        Debug.Log("Inventory pressed");
        GameEvents.instance.InvMenuPressed();
    }

    void StartMenu()
    {
        Debug.Log("Start menu pressed");
        GameEvents.instance.StartMenuPressed();
    }

    //void OnMenuOpen()
    //{
    //    menuOpen = true;
    //}

    //void OnMenuClose()
    //{
    //    menuOpen = false;
    //}



    //    void MenuCloseButton()
    //    {
    //        Debug.Log("Menu Close Button pressed");
    //        //close any menu thats open
    //        if (invMenuOpen)
    //            GameEvents.instance.InventoryPressed();
    //        if (startMenuOpen)
    //            GameEvents.instance.StartPressed();
    //    }

    //    void StartMenu()
    //    {
    //        Debug.Log("Start Menu pressed");
    //        GameEvents.instance.StartPressed();
    //        //if start menu already open, close it
    //        //else open the start menu
    //        //set startmenuopen to true
    //    }



    //    void InventoryItemAction(int actionId)
    //    {
    //        /*
    //         * Options when selecting heald item
    //         * Drop - Square
    //         * Select - X
    //         * Sheath - Triangle
    //         * 
    //         * Options when selecting a sheath item
    //         * Drop - Square
    //         * Select - X
    //         * Equip - X
    //         * Swap - Triangle
    //         */

    //        switch (actionId)
    //        {
    //            case 0:     // X
    //                //select whatever is hovered
    //                Select(actionId);
    //                return;
    //            case 1:     // Square
    //                //drop whatever is hovered
    //                Drop(actionId);
    //                return;
    //            case 2:     // Triangle
    //                //if same square hovered as selected, start swap
    //                //if a different item is hovered than the one selected,
    //                //check if they have the same sheathid (-1 for materials, 2 for tools) and if they do, swap them
    //                Swap(actionId);
    //                return;
    //            case 3:  // Circle
    //                     //if trade started, cancel the trading
    //                     //if nothing is trading, close the menu
    //                    if (invMenuOpen)
    //                    {
    //                        //if (Inventory.instance.swapStarted)
    //                        //{
    //                        //    CancelSwap(actionId);
    //                        //}
    //                        //else
    //                        //    GameEvents.current.InventoryPressed();
    //                    }
    //                    else if (startMenuOpen)
    //                    {
    //                        //GameEvents.current.StartPressed();
    //                    }
    //                    break;
    //            default:
    //                Debug.Log("Input outside of 0-4");
    //                return;
    //        }

    //    }

    //    void Select(int id)
    //    {
    //        Debug.Log("Select pressed");
    //        //Inventory.instance.OnActionButton(id);
    //    }

    //    void Drop(int id)
    //    {
    //        //if (manipulating item then trigeger drop event, otherwise, dont (so that the button does other funtionality when not manipulating)
    //        Debug.Log("Drop item pressed");
    //        //GameEvents.current.DropItem();
    //        //Inventory.instance.OnActionButton(id);
    //    }

    //    void Swap(int id)
    //    {
    //        Debug.Log("Swap pressed");
    //        //Inventory.instance.OnActionButton(id);
    //    }

    //    void CancelSwap(int id)
    //    {
    //        Debug.Log("Swap pressed");
    //        //Inventory.instance.OnActionButton(id);
    //    }

    //    void Equip()
    //    {
    //        Debug.Log("Equip pressed");
    //    }



    //    private void InventoryOpened()
    //    {
    //        //PlayerAnimationController.instance.dirMoving = Vector2.zero;
    //        movementInput = Vector2.zero;
    //        invMenuOpen = true;
    //    }

    //    private void InventoryClosed()
    //    {
    //        invMenuOpen = false;
    //    }
}
