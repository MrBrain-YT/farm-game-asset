using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingMode : MonoBehaviour
{
    // Start is called before the first frame update
    public void CollectingItems()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            
            if (hit.collider.transform.tag == "earth_4")
            {
                print("hi");
                Destroy(hit.collider.gameObject);
                GameObject.FindGameObjectWithTag("inventory").transform.GetComponent<ItemsList>().mySeeds[0].count += Random.Range(5, 8);
            }
        }
    }
}
