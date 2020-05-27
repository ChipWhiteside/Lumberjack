using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Tool
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
        toolid = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void ActionButtonPressed(int id)
    {
        if (id == toolid)
        {
            Debug.Log("Axe swing");
            animator.SetTrigger("Axe Swing");
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
