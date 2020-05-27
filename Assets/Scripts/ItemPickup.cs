using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public Item item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Debug.Log("Collided with player");
            PickUp();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PickUp()
    {
        Debug.Log("Pickup " + item.name);
        bool addedItem = Inventory.instance.AddItem(item);
        if (addedItem)
        {
            Destroy(gameObject);
        }
    }
}
