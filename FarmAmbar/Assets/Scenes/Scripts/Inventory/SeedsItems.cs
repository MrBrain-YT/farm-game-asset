using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Items/seed", order = 51)]
public class SeedsItems : ScriptableObject
{
    public string Name;
    public int count;
    public Sprite icon;
    public string type;
    public bool showCount;
    public string Type;
}
