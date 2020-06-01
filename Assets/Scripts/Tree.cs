using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    // public GameObject playerFeet;

    //public int treeid;
    public Transform player;

    private int age = 0;
    private GameObject stump;
    private GameObject stumpBottom;
    private GameObject tree;
    private SpriteRenderer stumpSprite;
    private SpriteRenderer treeSprite;

    void Start()
    {
        //GameEvents.instance.onTreeGrow += onTreeGrow;

        tree = this.transform.GetChild(0).gameObject;
        stump = this.transform.GetChild(1).gameObject;

        stumpSprite = stump.GetComponent<SpriteRenderer>();
        treeSprite = tree.GetComponent<SpriteRenderer>();

        stumpSprite.sortingOrder = treeSprite.sortingOrder - 1;
    }

    void Update()
    {
        if (player.position.y < transform.position.y)
        {
            if (stump.GetComponent<SpriteRenderer>().sortingOrder > 0)
            {
                stumpSprite.sortingOrder -= 1000;
                treeSprite.sortingOrder -= 1000;
            }
        } else
        {
            if (stump.GetComponent<SpriteRenderer>().sortingOrder <= 0)
            {
                stumpSprite.sortingOrder += 1000;
                treeSprite.sortingOrder += 1000;
            }
        }
        ////FIX THIS IT IS SUPER INEFFICIENT
        //if (PlayerController.instance.player.transform.position.y < transform.position.y)
        //{
        //    if (stump.GetComponent<SpriteRenderer>().sortingOrder > 0)
        //    {
        //        stump.GetComponent<SpriteRenderer>().sortingOrder -= 1000;
        //        tree.GetComponent<SpriteRenderer>().sortingOrder -= 1000;
        //    }
        //}
        //if (PlayerController.instance.player.transform.position.y >= transform.position.y)
        //{
        //    if (stump.GetComponent<SpriteRenderer>().sortingOrder < 0)
        //    {
        //        stump.GetComponent<SpriteRenderer>().sortingOrder += 1000;
        //        tree.GetComponent<SpriteRenderer>().sortingOrder += 1000;
        //    }
        //}
    }

    void FindNearestTree()
    {
        //gameObject.FindGameObjectsWithTag("");
    }

    private void onTreeGrow()
    {
        Debug.Log("Tree grew");
        age += 1;
    }

    private void ChopDownTree()
    {
        //tree.GetComponent<SpriteRenderer>().sprite = Resources.Load(stumpSprite) as Sprite;
    }
}
