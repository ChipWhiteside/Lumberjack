using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : Tool
{

    public Animator animator;

    /*
     * 0 = Axe
     * 1 = Pickaxe
     */
    private int toolid;

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onActionButtonPressed += ActionButtonPressed;
        toolid = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void ActionButtonPressed(int id)
    {
        if (id == toolid)
        {
            Debug.Log("Pickaxe swing");
            animator.SetTrigger("Pickaxe Swing");
        }
    }

    //public int GetToolId()
    //{
    //    return toolid;
    //}

    public override int GetToolId()
    {
        return toolid;
    }
}
