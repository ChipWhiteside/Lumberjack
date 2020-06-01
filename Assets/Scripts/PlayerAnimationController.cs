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

    private Animator animator;

    public Vector2 dirFacing;
    public Vector2 dirMoving;
    public int itemAnimID;

    void Start()
    {
        animator = GetComponent<Animator>();
        dirFacing = Vector2.zero;
        dirMoving = Vector2.zero;
        itemAnimID = -1;
    }

    void Update()
    {
        UpdateAnimations();
    }

    void UpdateAnimations()
    {
        animator.SetInteger("Direction Facing X", (int) dirFacing.x);
        animator.SetInteger("Direction Facing Y", (int) dirFacing.y);

        animator.SetInteger("Direction Moving X", (int) dirMoving.x);
        animator.SetInteger("Direction Moving Y", (int) dirMoving.y);

        animator.SetInteger("Item Animation ID", itemAnimID);
    }
}
