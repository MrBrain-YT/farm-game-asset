using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsList : MonoBehaviour 
{

    public object value;
    public List<MaterialsItems> myVariables;
    public MaterialsItems tree;
    public MaterialsItems Brick;
    public MaterialsItems rock;

    private void Start()
    {
        myVariables = new List<MaterialsItems>();
        myVariables.Add(tree);
        myVariables.Add(Brick);
        myVariables.Add(rock);

    }

    public ItemsList(MaterialsItems value)
    {
        this.value = value;
    }
}
