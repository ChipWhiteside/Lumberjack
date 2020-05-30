using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public int day;
    //public float time = 710.0f;
    //public Canvas canvas;

    ////private bool inventoryOpen;
    ////private int treeId = 0;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    //canvas.enabled = false;
    //    //inventoryOpen = false;
    //    //foreach (GameObject tree in GameObject.FindGameObjectsWithTag("Tree")) {
    //        //tree.GetComponent<Tree>().treeid = treeId;
    //        //treeId++;
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    time += Time.deltaTime;
    //    //print("Time: " + time);

    //    if (time > 720.0f) //midnight
    //    {
    //        GameEvents.current.GrowTrees();
    //        time = 0.0f;
    //    }

    //    //if (Input.GetKeyDown(KeyCode.Tab))
    //    //{
    //    //    if (inventoryOpen)
    //    //        CloseInventoryMenu();
    //    //    else
    //    //        OpenInventoryMenu();
    //    //}

    //    /*
    //     * Watch for action button pressed
    //     */
    //    //if (Input.GetButtonDown("Inventory"))
    //    //{
    //    //    if (!inventoryOpen)
    //    //    {
    //    //        GameEvents.current.InventoryMenuOpened();

    //    //        inventoryOpen = true;
    //    //        canvas.enabled = true;
    //    //        Debug.Log("Inventory open: " + inventoryOpen);
    //    //    }
    //    //    else
    //    //    {
    //    //        GameEvents.current.InventoryMenuClosed();

    //    //        inventoryOpen = false;
    //    //        canvas.enabled = false;
    //    //        Debug.Log("Inventory open: " + inventoryOpen);
    //    //    }
    //    //}

        
    //}

    //public void SpawnTree(int treeid, Vector2 pos)
    //{
    //    //switch (treeid)
    //    //{
    //    //    case 0:
    //    //        Debug.Log("");
    //    //        break;
    //    //    default:
    //    //        Debug.Log("");
    //    //        break;
    //    //}
    //}

    //void OpenInventoryMenu()
    //{
    //    //SceneManager.LoadScene("Inventory Menu", LoadSceneMode.Additive);
    //    //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Inventory Menu"));
    //}

    //void CloseInventoryMenu()
    //{
    //    //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main Scene"));
    //}

    //void LayerTrees()
    //{
    //    foreach (GameObject tree in GameObject.FindGameObjectsWithTag("Tree"))
    //    {
    //        tree.transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = 1; //Tree
    //        tree.transform.GetChild(1).GetComponent<SpriteRenderer>().sortingOrder = 1; //Stump
    //    }
    //}
}
