using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public GameObject itemPanel;
    public GameObject content;
    private List<MaterialsItems> myVariables;
    private List<BuildingItems> myBuildings;
    private List<SeedsItems> mySeeds;
    public GameObject inventory;

    public int inventoryItems;
    // Start is called before the first frame update
    void Start()
    {
        myVariables = GameObject.Find("ObjectsVariable").GetComponent<ItemsList>().myMaterials;
        myBuildings = GameObject.Find("ObjectsVariable").GetComponent<ItemsList>().myBuildings;
        mySeeds = GameObject.Find("ObjectsVariable").GetComponent<ItemsList>().mySeeds;
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
            GameObject.Find("MenuController").GetComponent<MenuController>().BuildItemsPanel.SetActive(false);
            GameObject.Find("MenuController").GetComponent<MenuController>().plentingItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            PlayerPrefs.SetInt("Inventory", 1);
            InventoryBuilder();
        }
        else
        {
            InventoryBuilder();
        }
    }

    public void InventoryBuilder()
    {
        if (inventory.active == false)
        {
            PlayerPrefs.SetInt("Inventory", 1);
            inventory.SetActive(true);
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
                if (variable.count == 0)
                {

                }
                else
                {
                    GameObject item = Instantiate(itemPanel);
                    item.transform.SetParent(content.transform);
                    item.transform.localScale = new Vector3(1, 1, 1);
                    item.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>().sprite = variable.icon;
                    item.transform.GetChild(0).transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = variable.Name;
                    item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = variable.count.ToString();
                }
            }
        }
        else
        {
            inventory.SetActive(false);
            PlayerPrefs.SetInt("Inventory", 0);
        }
    }

    public void RefreshInventory()
    {
        inventoryItems = myVariables.Count;
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
            if (variable.count == 0)
            {

            }
            else
            {
                GameObject item = Instantiate(itemPanel);
                item.transform.SetParent(content.transform);
                item.transform.localScale = new Vector3(1, 1, 1);
                item.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>().sprite = variable.icon;
                item.transform.GetChild(0).transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = variable.Name;
                item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = variable.count.ToString();
            }
        }
    }

    public void OpenMaterialsTab()
    {
        inventoryItems = myVariables.Count;
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
            if (variable.count == 0)
            {

            }
            else
            {
                GameObject item = Instantiate(itemPanel);
                item.transform.SetParent(content.transform);
                item.transform.localScale = new Vector3(1, 1, 1);
                item.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>().sprite = variable.icon;
                item.transform.GetChild(0).transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = variable.Name;
                item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = variable.count.ToString();
            }
        }
    }

    public void OpenBuildingTab()
    {
        inventoryItems = myBuildings.Count;
        int CountChildrens = content.transform.childCount;
        for (int i = 0; i < CountChildrens; i++)
        {
            //Destroy(content.transform.GetChild(0).GetComponent<RectTransform>());
            Destroy(content.transform.GetChild(i).gameObject);
            //Destroy(gameObject.transform.Find("Item(Clone)"));
        }



        for (int i = 0; i < inventoryItems; i++)
        {
            BuildingItems variable = myBuildings[i];
            if (variable.count == 0)
            {

            }
            else
            {
                GameObject item = Instantiate(itemPanel);
                item.transform.SetParent(content.transform);
                item.transform.localScale = new Vector3(1, 1, 1);
                item.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>().sprite = variable.icon;
                item.transform.GetChild(0).transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = variable.Name;
                if (variable.showCount == true)
                {
                    item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = variable.count.ToString();
                }
                else
                {
                    item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "";
                }
            }
        }
    }

    public void OpenSeedTab()
    {
        inventoryItems = mySeeds.Count;
        int CountChildrens = content.transform.childCount;
        for (int i = 0; i < CountChildrens; i++)
        {
            //Destroy(content.transform.GetChild(0).GetComponent<RectTransform>());
            Destroy(content.transform.GetChild(i).gameObject);
            //Destroy(gameObject.transform.Find("Item(Clone)"));
        }



        for (int i = 0; i < inventoryItems; i++)
        {
            SeedsItems variable = mySeeds[i];
            if (variable.count == 0)
            {

            }
            else
            {
                GameObject item = Instantiate(itemPanel);
                item.transform.SetParent(content.transform);
                item.transform.localScale = new Vector3(1, 1, 1);
                item.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>().sprite = variable.icon;
                item.transform.GetChild(0).transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = variable.Name;
                item.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = variable.count.ToString();
            }
        }
    }
}
