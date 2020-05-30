using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    #region Singleton
    public static PlayerController instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of PlayerController");
            return;
        }
        instance = this;
    }
    #endregion

    private Camera cam;
    //private bool inAction = false;

    public Vector2 dirFacing;
    //public Interactable focus;
    public LayerMask clickableMask;
    public GameObject player;
    //public bool inventoryOpen = false;

    void Start()
    {
        cam = Camera.main;
        dirFacing = Vector2.zero;
        player = gameObject;
        //playerFeet = transform.GetChild(1).gameObject;
        //rb = GetComponent<Rigidbody2D>();
        //speed = 7;
        //sprintspeed = 15;
    }

    void Update()
    {
        /*
         * Watch for action button pressed
         */
        //if (Input.GetMouseButtonDown(0))
        //{
            
        //    TileClicked();
        //    ActionButtonPressed();
        //}

        /*
         * Watch for inventory selection swap
         */
        //for (int i = 0; i < 10; ++i)
        //{
        //    if (Input.GetKeyDown("" + i))
        //    {
        //        Debug.Log(i + " pressed");
        //        if (i == 0)
        //            inventorySelected = 9;
        //        else
        //            inventorySelected = i - 1;
        //        Debug.Log("Inventory selected: " + inventorySelected);
        //    }
        //}
    }

    void ActionButtonPressed()
    {
        //PlayerAnimationController.instance.movespeed = 0.0f;
        //PlayerAnimationController.instance.itemAnimID = Inventory.GetItemSelected().animID;

        RaycastHit2D[] hit = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 100f, clickableMask);
        foreach (RaycastHit2D h in hit) {
            if (h.collider != null)
            {
                Debug.Log("Hit: " + h.collider.name + " | " + h.point);
                //Interactable interactable = h.collider.GetComponent<Interactable>();
                //if (interactable != null)
                //    SetFocus(interactable);
            }
        }
    }

    void SwingAxe()
    {
        //animator.SetTrigger("Left Click");
    }

    Vector2 TileClicked()
    {
        Vector2 playerPos = new Vector2((int)transform.position.x, (int)transform.position.y);
        Vector3 floatmousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos = new Vector2((int)floatmousepos.x, (int)floatmousepos.y);
        //Vector3 diff = playerPos - mousepos;
        Debug.Log("Player pos: " + playerPos);
        Debug.Log("Mouse pos: " + mousePos);

        Vector2 clickedSquare = new Vector2(0, 0);
        //Find which horizontal square was selected
        if (mousePos.x == playerPos.x)
        {
            clickedSquare.x = playerPos.x;
        }
        else if (mousePos.x < playerPos.x)
        {
            clickedSquare.x = playerPos.x - 1;
        }
        else
        {
            clickedSquare.x = playerPos.x + 1;
        }
        //Find which verticle square was selected
        if (mousePos.y == playerPos.y)
        {
            clickedSquare.y = playerPos.y;
        }
        else if (mousePos.y < playerPos.y)
        {
            clickedSquare.y = playerPos.y - 1;
        }
        else
        {
            clickedSquare.y = playerPos.y + 1;
        }
        //if the player clicks the square they're standing on, make the activated square the one they're looking at.
        if (clickedSquare == playerPos)
        {
            Debug.Log("Same square clicked");
            clickedSquare = playerPos + dirFacing;
        }

        Debug.Log("Clicked square: " + clickedSquare);

        return clickedSquare;
    }

}
