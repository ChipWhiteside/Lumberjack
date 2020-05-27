using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int day;
    public float time = 710.0f;

    private int treeId = 0;
    private bool inventoryOpen;

    // Start is called before the first frame update
    void Start()
    {
        inventoryOpen = false;
        foreach (GameObject tree in GameObject.FindGameObjectsWithTag("Tree")) {
            tree.GetComponent<Tree>().treeid = treeId;
            treeId++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //print("Time: " + time);

        if (time > 720.0f) //midnight
        {
            GameEvents.current.GrowTrees();
            time = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventoryOpen)
                CloseInventoryMenu();
            else
                OpenInventoryMenu();
        }
    }

    public void SpawnTree(int treeid, Vector2 pos)
    {
        switch (treeid)
        {
            case 0:
                Debug.Log("");
                break;
            default:
                Debug.Log("");
                break;
        }
    }

    void OpenInventoryMenu()
    {
        SceneManager.LoadScene("Inventory Menu", LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Inventory Menu"));
    }

    void CloseInventoryMenu()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main Scene"));
        
        //SceneManager.un
    }
}
