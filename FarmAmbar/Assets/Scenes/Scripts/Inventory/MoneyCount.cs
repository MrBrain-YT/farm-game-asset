using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Items/Coins", order = 51)]
public class MoneyCount : ScriptableObject
{
    public int count;
}
