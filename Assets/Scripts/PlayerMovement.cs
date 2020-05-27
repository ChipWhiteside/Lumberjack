using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public float sprintspeed;

    private Vector2 dirFacing = Vector2.zero;
    private PlayerController pc;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PlayerController>();
        speed = 7;
        sprintspeed = 15;
    }
    

    void Update()
    {
        /*
         * Movement controls
         */
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            Vector2 movement = new Vector2(0f, 0f);

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            { //left or right
                movement.x = Input.GetAxis("Horizontal").CompareTo(0f);
            }
            else
            {
                movement.x = 0f;
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            { //up or down
                movement.y = Input.GetAxis("Vertical").CompareTo(0f);
            }
            else
            {
                movement.y = 0f;
            }

            pc.dirFacing = movement;
            PlayerAnimationController.instance.dirFacing = movement;

            //If player is moving two directions, slow speed;
            if (Input.GetButton("Horizontal") && Input.GetButton("Vertical"))
                movement *= .7f;

            //if the player is holding down shift, sprint
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = movement * sprintspeed;
                PlayerAnimationController.instance.movespeed = sprintspeed;
            }
            else
            {
                rb.velocity = movement * speed;
                PlayerAnimationController.instance.movespeed = speed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
            PlayerAnimationController.instance.movespeed = 0.0f;
        }
    }

    //void MovePlayer()
    //{
    //    dirFacing = moveTo;
    //    float tempSpeed = speed;
    //    if (moveTo.x != 0 && moveTo.y != 0) //if the player is moving in two directions, lower the speed.
    //        tempSpeed = speed / 1.5f;
    //}

    void StopMoving()
    {
        ////spriting = false;
        //animator.SetBool("Running", false);
        //animator.SetBool("Sprinting", false);
        //animator.SetFloat("xdir", moveTo.x);
        //animator.SetFloat("ydir", moveTo.y);
    }
}
