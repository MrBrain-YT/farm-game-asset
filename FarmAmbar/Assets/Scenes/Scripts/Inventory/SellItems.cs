using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Items/Sell", order = 51)]
public class SellItems : ScriptableObject
{
    public string Name;
    public int count;
    public Sprite icon;
    public bool showCount;
    public float cost;
}
