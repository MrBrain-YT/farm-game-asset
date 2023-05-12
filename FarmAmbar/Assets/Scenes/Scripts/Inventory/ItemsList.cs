using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsList : MonoBehaviour 
{

    public object value;
    public List<MaterialsItems> myVariables;
    public List<BuildingItems> myBuildings;
    public List<SeedsItems> mySeeds;

    // Material items
    public MaterialsItems tree;
    public MaterialsItems Brick;
    public MaterialsItems rock;

    // Building items
    public BuildingItems ground;
    public BuildingItems ambar;

    // Seed items
    public SeedsItems wheat;


    private void Start()
    {
        // Add material items to list 
        myVariables.Add(tree);
        myVariables.Add(Brick);
        myVariables.Add(rock);

        // Add building items to list 
        myBuildings.Add(ground);
        myBuildings.Add(ambar);

        // Add seed items to list 
        mySeeds.Add(wheat);
    }

    public ItemsList(MaterialsItems value)
    {
        this.value = value;
    }
}
