using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
public class ItemManager : MonoBehaviour
{

    public Item item;
    public SpriteRenderer sr;
    public CircleCollider2D ccollider;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        ccollider = GetComponent<CircleCollider2D>();

        sr.sprite = item.icon;
        sr.sortingLayerName = "Player";
        ccollider.radius = item.itemRadius;
        ccollider.isTrigger = true;
    }

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
        bool itemAdded = Inventory.instance.AddItem(item);
        if (itemAdded)
        {
            Destroy(gameObject);
        }
    }
}
