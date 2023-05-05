using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;


public class Inventory : MonoBehaviour
{
    public GameObject itemPanel;
    public GameObject content;
    private List<MaterialsItems> myVariables;
    public MaterialsItems tree;
    public GameObject inventoryBarrier;

    public int inventoryItems;
    // Start is called before the first frame update
    void Start()
    {
        myVariables = GameObject.Find("ObjectsVariable").GetComponent<ItemsList>().myVariables;
        inventoryItems = myVariables.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            OpenInventory();
        }
    }

    public void OpenInventory()
    {
        if (PlayerPrefs.GetInt("Build_mode") == 1 || PlayerPrefs.GetInt("Destroy_mode") == 1 || PlayerPrefs.GetInt("Move_mode") == 1 || PlayerPrefs.GetInt("Plenting_mode") == 1)
        {

        }
        else
        {
            if (inventoryBarrier.active == false)
            {
                PlayerPrefs.SetInt("Inventory", 1);
                inventoryBarrier.SetActive(true);
                inventoryItems = myVariables.Count;
                print(inventoryItems);
                int CountChildrens = content.transform.childCount;
                for (int i = 0; i < CountChildrens; i++)
                {
                    //Destroy(content.transform.GetChild(0).GetComponent<RectTransform>());
                    Destroy(content.transform.GetChild(i).gameObject);
                    //Destroy(gameObject.transform.Find("Item(Clone)"));
                }



                for (int i = 0; i < inventoryItems; i++)
                {
                    MaterialsItems variable = myVariables[i];
                    GameObject item = Instantiate(itemPanel);
                    item.transform.SetParent(content.transform);
                    item.transform.localScale = new Vector3(1, 1, 1);
                    item.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>().sprite = variable.icon;
                    item.transform.GetChild(0).transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = variable.Name;
                    item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = variable.count.ToString();
                }
            }
            else
            {
                print("hello");
                inventoryBarrier.SetActive(false);
                PlayerPrefs.SetInt("Inventory", 0);
            }
        }
    }
    public void RefreshInventory()
    {
        inventoryItems = myVariables.Count;
        print(inventoryItems);
        int CountChildrens = content.transform.childCount;
        for (int i = 0; i < CountChildrens; i++)
        {
            //Destroy(content.transform.GetChild(0).GetComponent<RectTransform>());
            Destroy(content.transform.GetChild(i).gameObject);
            //Destroy(gameObject.transform.Find("Item(Clone)"));
        }



        for (int i = 0; i < inventoryItems; i++)
        {
            MaterialsItems variable = myVariables[i];
            GameObject item = Instantiate(itemPanel);
            item.transform.SetParent(content.transform);
            item.transform.localScale = new Vector3(1, 1, 1);
            item.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>().sprite = variable.icon;
            item.transform.GetChild(0).transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = variable.Name;
            item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = variable.count.ToString();
        }
    }
}
