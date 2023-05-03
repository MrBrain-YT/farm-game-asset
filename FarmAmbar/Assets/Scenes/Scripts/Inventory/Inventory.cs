using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject itemPanel;
    public GameObject content;
    public ScriptableObject tree;
    public int inventoryItems;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenInventory()
    {
        for (int i = 0; i < inventoryItems; i++)
        {
            GameObject item  = Instantiate(itemPanel);
            item.transform.parent = content.transform;
        }
    }
}
