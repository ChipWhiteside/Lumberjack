using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tool : MonoBehaviour
{
    /*
     * 0 = Axe
     * 1 = Pickaxe
     */
    private int toolid;

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onActionButtonPressed += ActionButtonPressed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public abstract void ActionButtonPressed(int id);

    //private void ActionButtonPressed(int id)
    //{
    //    if (id == toolid)
    //    {
    //        Debug.Log("Action button pressed");
    //    }
    //}

    public abstract int GetToolId();

}
