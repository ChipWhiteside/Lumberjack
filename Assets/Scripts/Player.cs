using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player instance;

    public PlayerInputActions controls;
    public Rigidbody2D rb;
    public float speed = 7f;

    public List<bool> sheathsEquipped = new List<bool>();

    private Vector2 movementInput = Vector2.zero;
    private Vector2 directionFacing = Vector2.zero;
    private bool invMenuOpen;
    private bool startMenuOpen;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of PlayerController");
            return;
        }
        instance = this;

        controls = new PlayerInputActions();
        controls.Player.Select.performed += context => Action();
        controls.Player.StartMenu.performed += context => StartMenu();
        controls.Player.MenuClose.performed += context => MenuCloseButton();
        controls.Player.Inventory.performed += context => Inventory();
        controls.Player.Equip.performed += context => Equip();
        controls.Player.Swap.performed += context => Swap();
        controls.Player.Sprint.performed += context => speed = 10.0f;
        controls.Player.Sprint.canceled += context => speed = 7f;
        controls.Player.Movement.performed += context =>  Move(context.ReadValue<Vector2>());
        //controls.Player.Movement.performed += context => directionFacing = context.ReadValue<Vector2>();
        controls.Player.Movement.canceled += context => MoveCancelled(context.ReadValue<Vector2>());
        //controls.Player.Movement.canceled += context => directionFacing = context.ReadValue<Vector2>();

        rb = GetComponent<Rigidbody2D>();
        invMenuOpen = false;
        startMenuOpen = false;
    }

    private void Start()
    {
        GameEvents.current.onInventoryOpened += InventoryOpened;
        GameEvents.current.onInventoryClosed += InventoryClosed;
    }

    private void Update()
    {
        //Debug.Log("movementInput" + movementInput);
        //Debug.Log("directionFacing" + directionFacing);

       
        rb.velocity = movementInput * speed;
        PlayerAnimationController.instance.dirFacing = directionFacing;
        PlayerAnimationController.instance.dirMoving = movementInput;
        
        //if (movementInput != Vector2.zero)
        //{
        //    Move();
        //}
        //Debug.Log("Speed" + speed);
    }

    void Action()
    {
        Debug.Log("Action pressed");
    }

    void Inventory()
    {
        Debug.Log("Inventory pressed");
        GameEvents.current.InventoryPressed();
        //if inventory is already open, close it
    }

    void Move(Vector2 movement)
    {
        Debug.Log("Move pressed " + movement);
        if (!invMenuOpen && !startMenuOpen)   // if no menu's are open then move player
        {
            movementInput = movement;
            directionFacing = movement;
        }
    }

    void MoveCancelled(Vector2 movement)
    {
        Debug.Log("Move cancelled");
        movementInput = movement;
    }

    void MenuCloseButton()
    {
        Debug.Log("Menu Close Button pressed");
        //close any menu thats open
        if (invMenuOpen)
            GameEvents.current.InventoryPressed();
        if (startMenuOpen)
            GameEvents.current.StartPressed();
    }

    void StartMenu()
    {
        Debug.Log("Start Menu pressed");
        GameEvents.current.StartPressed();
        //if start menu already open, close it
        //else open the start menu
        //set startmenuopen to true
    }

    void DropItem()
    {
        Debug.Log("Drop item pressed");
        GameEvents.current.DropItem();
        //if start menu already open, close it
        //else open the start menu
        //set startmenuopen to true
    }

    void Swap()
    {
        /*
         * Options when selecting heald item
         * Drop - Square
         * Select - X
         * Sheath - Triangle
         * 
         * Options when selecting a sheath item
         * Drop - Square
         * Select - X
         * Equip - X
         * Swap - Triangle
         */
    }

    void Equip()
    {
        //hook up
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void InventoryOpened()
    {
        //PlayerAnimationController.instance.dirMoving = Vector2.zero;
        movementInput = Vector2.zero;
        invMenuOpen = true;
    }

    private void InventoryClosed()
    {
        invMenuOpen = false;
    }
}
