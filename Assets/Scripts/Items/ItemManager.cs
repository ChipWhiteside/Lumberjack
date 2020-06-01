using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
public class ItemManager : MonoBehaviour
{

    public Item item;
    private SpriteRenderer sr;
    private CircleCollider2D ccollider;

    private void Awake()
    {
        SetupItem();
    }

    private void Start()
    {
        GameEvents.instance.onItemInteract += Interact;
        GameEvents.instance.onPickupItemSuccess += PickupSuccess;
        GameEvents.instance.onPickupItemFail += PickupFail;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Debug.Log(item.name + " collided with player");
            Interact();
        }
    }

    void Interact()
    {
        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        GameEvents.instance.PickupItem(item);
    }

    void PickupSuccess()
    {
        Destroy(gameObject);
        Debug.Log("Picked up " + item.name);
    }

    void PickupFail()
    {
        Debug.Log("Can't pickup " + item.name);
    }

    public void SetupItem()
    {
        Debug.Log("Setting up " + item.name);

        sr = GetComponent<SpriteRenderer>();
        ccollider = GetComponent<CircleCollider2D>();

        sr.sprite = item.icon;
        sr.sortingLayerName = "Player";
        //ccollider.radius = item.itemRadius;
        ccollider.isTrigger = true;
    }
}
