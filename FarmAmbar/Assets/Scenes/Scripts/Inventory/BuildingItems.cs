using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Items/Building", order = 51)]
public class BuildingItems : ScriptableObject
{
    public bool finished;
    public int stage;
    public int count;
    public Sprite icon;
    public string Name;
    public bool exists;
    public bool showCount;
    public string Type;
}
