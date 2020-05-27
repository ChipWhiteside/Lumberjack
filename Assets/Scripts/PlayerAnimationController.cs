using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    #region Singleton
    public static PlayerAnimationController instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of Player Animation Controller");
            return;
        }
        instance = this;
    }
    #endregion

    public Animator animator;

    public float movespeed;
    public Vector2 dirFacing;
    public int itemAnimID;

    void Start()
    {
        animator = GetComponent<Animator>();
        movespeed = 0;
        dirFacing = Vector2.zero;
        itemAnimID = -1;
    }

    void Update()
    {
        UpdateAnimations();
    }

    public void UpdateAnimations()
    {
        animator.SetFloat("Move Speed", movespeed);
        animator.SetFloat("Direction Facing X", dirFacing.x);
        animator.SetFloat("Direction Facing Y", dirFacing.y);
        animator.SetInteger("Item Animation ID", itemAnimID);
    }
}
