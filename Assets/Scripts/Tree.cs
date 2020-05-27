using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    public GameObject playerFeet;

    public int treeid;

    private int age = 0;
    private GameObject stump;
    private GameObject stumpBottom;
    private GameObject tree;

    private string stumpSprite = "Assets/2D Sprites/Pine Stump.png";

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onTreeGrow += onTreeGrow;

        tree = this.transform.GetChild(0).gameObject;
        stump = this.transform.GetChild(1).gameObject;
        //stumpBottom = stump.transform.GetChild(0).gameObject;

        stump.GetComponent<SpriteRenderer>().sortingOrder = tree.GetComponent<SpriteRenderer>().sortingOrder - 1;
        //Debug.Log("tree: " + tree.name);
        //Debug.Log("stump: " + stump.name);
        //Debug.Log("stumpBottom: " + stumpBottom.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Playerfeet: " + playerFeet.transform.position.y);
        //Debug.Log("Stump: " + stump.transform.position.y);
        if (playerFeet.transform.position.y < transform.position.y)
        {
            //Debug.Log("Background");
            stump.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
            tree.GetComponent<SpriteRenderer>().sortingLayerName = "Background";
        }
        if (playerFeet.transform.position.y >= transform.position.y)
        {
            //Debug.Log("Foreground");
            stump.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
            tree.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
        }
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
        tree.GetComponent<SpriteRenderer>().sprite = Resources.Load(stumpSprite) as Sprite;
    }
}
