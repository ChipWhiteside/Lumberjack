using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{

    new public string name = "New Item";
    public string type = "Weapon";
    public int animID = 0;
    public Sprite icon = null;

}
