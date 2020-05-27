using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float sprintspeed;
    public Rigidbody2D rb;
    public Animator animator;
    public GameObject[] inventory = new GameObject[10];

    private bool inAction = false;
    private int inventorySelected = 0;
    private Vector2 moveTo = new Vector2(0, 0);
    private GameObject playerFeet;
    private Vector2 dirFacing = new Vector2(0, 0);
    //private bool spriting = false;

    void Start()
    {
        playerFeet = transform.GetChild(1).gameObject;
        rb = GetComponent<Rigidbody2D>();
        speed = 7;
        sprintspeed = 15;
    }

    private void FixedUpdate()
    {
        
    }

    void Update()
    {

        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    spriting = true;
        //}
        //if (Input.GetKeyUp(KeyCode.LeftShift))
        //{
        //    spriting = false;
        //}


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal.CompareTo(0f), moveVertical.CompareTo(0f));
        

        

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            //float moveHorizontal = Input.GetAxis("Horizontal");
            //float moveVertical = Input.GetAxis("Vertical");
            //Vector2 movement = new Vector2(moveHorizontal.CompareTo(0f), moveVertical.CompareTo(0f));

            if (Input.GetButton("Horizontal") && Input.GetButton("Vertical"))
            {
                movement *= .7f;
            }

            /*
             * The issue is that when the player changes directions, because "moveHorizontal" or "moveVertical" takes time to go from 1 to
             * 0 when the player releases the key, they go diagonally until it hits 0. The whateverUp event only happens when it hits 0 so
             * its pointless.
            */

            //if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            //{
            //    //movement = new Vector2(moveHorizontal.CompareTo(0f), 0);
            //    Debug.Log("Vertical up");
            //    movement.y = 0;
            //}

            //if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            //{
            //    //movement = new Vector2(0, moveVertical.CompareTo(0f));
            //    Debug.Log("Horizontal up");
            //    movement.x = 0;
            //}

            Debug.Log("movement: " + movement);
            Debug.Log("x move: " + moveHorizontal);
            Debug.Log("y move: " + moveVertical);
            if (Input.GetKey(KeyCode.LeftShift))
                rb.velocity = movement * sprintspeed;
            else
                rb.velocity = movement * speed;
        }
        else
            rb.velocity = Vector2.zero;


        ////Movement Control
        //if (Input.GetKey(KeyCode.W))
        //{ //UP
        //    moveTo.y = 1;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{ //LEFT
        //    moveTo.x = -1;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{ //DOWN
        //    moveTo.y = -1;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{ //RIGHT
        //    moveTo.x = 1;
        //}

        //if (Input.GetKeyUp(KeyCode.W))
        //{ //UP
        //    moveTo.y = 0;
        //}
        //if (Input.GetKeyUp(KeyCode.A))
        //{ //LEFT
        //    moveTo.x = 0;
        //}
        //if (Input.GetKeyUp(KeyCode.S))
        //{ //DOWN
        //    moveTo.y = 0;
        //}
        //if (Input.GetKeyUp(KeyCode.D))
        //{ //RIGHT
        //    moveTo.x = 0;
        //}

        //if (moveTo.x != 0 || moveTo.y != 0)
        //{
        //    MovePlayer();
        //}
        //else if (moveTo.x == 0 && moveTo.y == 0)
        //{
        //    StopMoving();
        //}

        //Debug.Log("pivot: " + this.transform.GetComponent<SpriteRenderer>().sprite.pivot.normalized);

        if (Input.GetMouseButtonDown(0))
        {
            TileClicked();
            ActionButtonPressed();
        }

        //Watch for inventory selction swapped
        for (int i = 0; i < 10; ++i)
        {
            if (Input.GetKeyDown("" + i))
            {
                Debug.Log(i + " pressed");
                if (i == 0)
                    inventorySelected = 9;
                else
                    inventorySelected = i - 1;
                Debug.Log("Inventory selected: " + inventorySelected);
            }
        }
    }

    void MovePlayer()
    {
        dirFacing = moveTo;
        //animator.SetFloat("xdir", moveTo.x);
        //animator.SetFloat("ydir", moveTo.y);
       // animator.SetBool("Running", true);
        float tempSpeed = speed;
        if (moveTo.x != 0 && moveTo.y != 0) //if the player is moving in two directions, lower the speed.
            tempSpeed = speed / 1.5f;
        //if (Input.GetKey(KeyCode.LeftShift)) { //check if player is walking, if so lower speed more.
        //    tempSpeed /= 2;
        //}
        //if (spriting)
        //{
        //    animator.SetBool("Running", false);
        //    animator.SetBool("Sprinting", true);
        //    tempSpeed *= 1.5f;
        //    Debug.Log("Sprinting");
        //}
        //else
        //{
        //    animator.SetBool("Sprinting", false);
        //    animator.SetBool("Running", true);
        //}
        //transform.position += (Vector3) (moveTo * tempSpeed * Time.deltaTime); //move the player
        //rb.AddForce(moveTo * tempSpeed * Time.deltaTime);
        //rb.velocity = moveTo * tempSpeed;
    }

    void StopMoving() {
        //spriting = false;
        animator.SetBool("Running", false);
        animator.SetBool("Sprinting", false);
        animator.SetFloat("xdir", moveTo.x);
        animator.SetFloat("ydir", moveTo.y);
    }

    void ActionButtonPressed()
    { 
        GameObject toolselected = inventory[inventorySelected]; //whatever tool is selected
        if (toolselected != null)
        {
            Debug.Log("Tool selected: " + toolselected.name);
            Debug.Log("Tool id: " + toolselected.GetComponent<Tool>().GetToolId());
            GameEvents.current.ActionButtonPressed(toolselected.GetComponent<Tool>().GetToolId());
        }
    }

    void SwingAxe()
    {
        animator.SetTrigger("Left Click");
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
