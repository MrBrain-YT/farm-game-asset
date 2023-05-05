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
        int CountChildrens = content.transform.childCount;
        for (int i = 0; i < CountChildrens; i++)
        {
            //Destroy(content.transform.GetChild(0).GetComponent<RectTransform>());
            Destroy(content.transform.GetChild(0).gameObject);
            //Destroy(gameObject.transform.Find("Item(Clone)"));
        }

            for (int i = 0; i < inventoryItems; i++)
        {
            GameObject item  = Instantiate(itemPanel);
            item.transform.SetParent(content.transform);
            item.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
