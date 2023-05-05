using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Items/material", order = 51)]
public class MaterialsItems : ScriptableObject
{
    public string Name;
    public int count;
    public Sprite icon;
}
