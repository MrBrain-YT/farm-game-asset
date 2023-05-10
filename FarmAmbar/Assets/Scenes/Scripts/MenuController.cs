using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject BuildItemsPanel;
    public GameObject plentingItemsPanel;
    public GameObject player;
    public GameObject inventory;

    public List<BuildingItems> buildingItems;
    public GameObject PlantAndBuldPanel;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Move_mode", 0);
        PlayerPrefs.SetInt("Plenting_mode", 0);
        PlayerPrefs.SetInt("Build_mode", 0);
        PlayerPrefs.SetInt("Inventory", 0);
        PlayerPrefs.SetString("CurrentBuildItem", "");
        buildingItems = GameObject.Find("ObjectsVariable").GetComponent<ItemsList>().myBuildings;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBuildMode()
    {
        if (PlayerPrefs.GetInt("Build_mode") == 0)
        {
            plentingItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Build_mode", 1);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Inventory", 0);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            BuildItemsPanel.SetActive(true);
            inventory.SetActive(false);

            int Chailds = BuildItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.childCount;
            for (int i = 0; i < Chailds; i++)
            {
                Destroy(BuildItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).gameObject);
            }

            int BuildItems = buildingItems.Count;
            for (int j = 0; j < BuildItems; j++)
            {
                print(j);
                GameObject panel = Instantiate(PlantAndBuldPanel);
                panel.transform.SetParent(BuildItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform);
                panel.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = buildingItems[j].Name;
                panel.transform.GetChild(0).GetComponent<Image>().sprite = buildingItems[j].icon;
                panel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = buildingItems[j].count.ToString();
                panel.transform.localScale = new Vector3(0.2824726f, -0.700887f, 2.530084f);
            }
            //BuildItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => OnBuildMode());
        }
        else
        {
            plentingItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Inventory", 0);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            BuildItemsPanel.SetActive(false);
            inventory.SetActive(false);
            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
        }
    }
    public void OnDestroyMode()
    {
        if (PlayerPrefs.GetInt("Destroy_mode") == 0)
        {
            plentingItemsPanel.SetActive(false);
            BuildItemsPanel.SetActive(false);
            inventory.SetActive(false);
            PlayerPrefs.SetInt("Destroy_mode", 1);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Inventory", 0);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
        }
        else
        {
            plentingItemsPanel.SetActive(false);
            BuildItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
        }
    }

    public void OnPlentingMode()
    {
        if (PlayerPrefs.GetInt("Plenting_mode") == 0)
        {
            PlayerPrefs.SetInt("Inventory", 0);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Plenting_mode", 1);
            BuildItemsPanel.SetActive(false);
            plentingItemsPanel.SetActive(true);
            inventory.SetActive(false);
        }
        else
        {
            BuildItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            plentingItemsPanel.SetActive(false);
        }
    }


    public void DestroyMenuObject()
    {
        player.GetComponent<ReplaceObject>().MenuPanel.SetActive(false);
        player.GetComponent<ReplaceObject>().itemDialogPanel.SetActive(false);
        GameObject AddStartGround = player.GetComponent<createMarcer>().AddStartGround;
        player.GetComponent<createMarcer>().GroundXZ.Remove((player.GetComponent<createMarcer>().xToMenuController.ToString() + (player.GetComponent<createMarcer>().zToMenuController).ToString()));
        Destroy(player.GetComponent<ReplaceObject>().curentObject);
    }

    public void ActiveBuildGround()
    {
        PlayerPrefs.SetString("CurrentBuildItem", "Ground_1");
    }

    public void MoveMenuObject()
    {
        PlayerPrefs.SetInt("Destroy_mode", 0);
        PlayerPrefs.SetInt("Build_mode", 0);
        PlayerPrefs.SetInt("Move_mode", 1);
        player.GetComponent<ReplaceObject>().MenuPanel.SetActive(false);
        player.GetComponent<ReplaceObject>().itemDialogPanel.SetActive(false);
        player.GetComponent<createMarcer>().GroundXZ.Remove((player.GetComponent<createMarcer>().xToMenuController.ToString() + (player.GetComponent<createMarcer>().zToMenuController).ToString()));
    }
}
