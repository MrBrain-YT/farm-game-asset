using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellInventory : MonoBehaviour
{
    public GameObject sellItemPanel;
    public GameObject content;
    public GameObject SellItemsPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Selling_mode") == 1)
        {
            OpenSellInventory();
        }
    }

    public void OpenSellInventory()
    {
        if (PlayerPrefs.GetInt("Selling_mode") == 1 || PlayerPrefs.GetInt("Build_mode") == 1 || PlayerPrefs.GetInt("Destroy_mode") == 1 || PlayerPrefs.GetInt("Move_mode") == 1 || PlayerPrefs.GetInt("Plenting_mode") == 1)
        {
            GameObject.Find("MenuController").GetComponent<MenuController>().BuildItemsPanel.SetActive(false);
            GameObject.Find("MenuController").GetComponent<MenuController>().plentingItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            PlayerPrefs.SetInt("Selling_mode", 0);
            PlayerPrefs.SetInt("Inventory", 1);
            SellInventoryBuilder();
        }
        else
        {
            SellInventoryBuilder();
        }
    }

    public void SellInventoryBuilder()
    {
        if (SellItemsPanel.active == false)
        {
            SellItemsPanel.SetActive(true);

        }
        else
        {
            SellItemsPanel.SetActive(false);
        }
    }
}
