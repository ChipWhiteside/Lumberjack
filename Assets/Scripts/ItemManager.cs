using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemManager : MonoBehaviour
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
