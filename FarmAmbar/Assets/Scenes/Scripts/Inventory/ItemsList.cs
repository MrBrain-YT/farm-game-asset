using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsList : MonoBehaviour 
{

    public object value;
    public List<MaterialsItems> myMaterials;
    public List<BuildingItems> myBuildings;
    public List<SeedsItems> mySeeds;
    public List<SellItems> mySells;


    private void Start()
    {
        // Add material items to list 
        /*myVariables.Add(tree);
        myVariables.Add(Brick);
        myVariables.Add(rock);

        // Add building items to list 
        myBuildings.Add(ground);
        myBuildings.Add(ambar);

        // Add seed items to list 
        mySeeds.Add(wheat);
        mySeeds.Add(tomat);*/
    }

    public ItemsList(MaterialsItems value)
    {
        this.value = value;
    }
}
