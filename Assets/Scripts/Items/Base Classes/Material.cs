using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : Item
{
    public MaterialType materialType;
}

public enum MaterialType { Wood, Ore }
