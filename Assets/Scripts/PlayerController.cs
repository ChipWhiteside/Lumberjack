using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private bool inAction = false;

    public Vector2 dirFacing;
    public Interactable focus;
    public LayerMask clickableMask;

    void Start()
    {
        cam = Camera.main;
        dirFacing = Vector2.zero;
        //playerFeet = transform.GetChild(1).gameObject;
        //rb = GetComponent<Rigidbody2D>();
        //speed = 7;
        //sprintspeed = 15;
    }

    private void FixedUpdate()
    {
        
    }

    void Update()
    {

        /*
        * Camera movement
        */
        //float hmovement = Input.GetAxis("Horizontal");
        //float vmovement = Input.GetAxis("Vertical");
        //if (hmovement != 0 || vmovement != 0)
        //    cam.transform.position += new Vector3(hmovement, vmovement, 0.0f).normalized;
        //else
        //    cam.transform.position = transform.position + new Vector3(0f, 0f, -10f); //reset the cams position to be on the player


        /*
         * Movement controls
         */
        //if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        //{
            
        //    Vector2 movement = new Vector2(0f, 0f);

        //    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        //    { //left or right
        //        movement.x = Input.GetAxis("Horizontal").CompareTo(0f);
        //    }
        //    else
        //    {
        //        movement.x = 0f;
        //    }
        //    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        //    { //up or down
        //        movement.y = Input.GetAxis("Vertical").CompareTo(0f);
        //    }
        //    else
        //    {
        //        movement.y = 0f;
        //    }

        //    //If player is moving two directions, slow speed;
        //    if (Input.GetButton("Horizontal") && Input.GetButton("Vertical"))
        //        movement *= .7f;

        //    //if the player is holding down shift, sprint
        //    if (Input.GetKey(KeyCode.LeftShift))
        //        rb.velocity = movement * sprintspeed;
        //    else
        //        rb.velocity = movement * speed;
        //}
        //else 
        //    rb.velocity = Vector2.zero;

        /*
         * Watch for action button pressed
         */
        if (Input.GetMouseButtonDown(0))
        {
            
            TileClicked();
            ActionButtonPressed();
        }

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

    //void MovePlayer()
    //{
    //    dirFacing = moveTo;
    //    float tempSpeed = speed;
    //    if (moveTo.x != 0 && moveTo.y != 0) //if the player is moving in two directions, lower the speed.
    //        tempSpeed = speed / 1.5f;
    //}

    //void StopMoving() {
    //    ////spriting = false;
    //    //animator.SetBool("Running", false);
    //    //animator.SetBool("Sprinting", false);
    //    //animator.SetFloat("xdir", moveTo.x);
    //    //animator.SetFloat("ydir", moveTo.y);
    //}

    void ActionButtonPressed()
    {
        PlayerAnimationController.instance.movespeed = 0.0f;
        //PlayerAnimationController.instance.itemAnimID = Inventory.GetItemSelected().animID;

        RaycastHit2D[] hit = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 100f, clickableMask);
        foreach (RaycastHit2D h in hit) {
            if (h.collider != null)
            {
                Debug.Log("Hit: " + h.collider.name + " | " + h.point);
                Interactable interactable = h.collider.GetComponent<Interactable>();
                if (interactable != null)
                    SetFocus(interactable);
            }
        }
        

        //GameObject toolselected = Inventory.instance. //whatever tool is selected
        //if (toolselected != null)
        //{
        //    Debug.Log("Tool selected: " + toolselected.name);
        //    Debug.Log("Tool id: " + toolselected.GetComponent<Tool>().GetToolId());
        //    GameEvents.current.ActionButtonPressed(toolselected.GetComponent<Tool>().GetToolId());
        //}
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

    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }

    void LooseFocus()
    {
        focus = null;
    }

    private void AddDescendantsWithTag(Transform parent, string tag, List<GameObject> list)
    {
        foreach (Transform child in parent)
        {
            if (child.gameObject.tag == tag)
            {
                list.Add(child.gameObject);
            }
            AddDescendantsWithTag(child, tag, list);
        }
    }

}
