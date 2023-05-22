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
    public List<SeedsItems> seedsItems;
    public GameObject PlantPanel;
    public GameObject BuildPanel;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Move_mode", 0);
        PlayerPrefs.SetInt("Plenting_mode", 0);
        PlayerPrefs.SetInt("Build_mode", 0);
        PlayerPrefs.SetInt("Inventory", 0);
        PlayerPrefs.SetInt("Collecting_mode", 0);
        PlayerPrefs.SetString("CurrentBuildItem", "");
        PlayerPrefs.SetString("CurrentSeed", "");
        buildingItems = GameObject.Find("ObjectsVariable").GetComponent<ItemsList>().myBuildings;
        seedsItems = GameObject.Find("ObjectsVariable").GetComponent<ItemsList>().mySeeds;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBuildMode()
    {
        if (PlayerPrefs.GetInt("Build_mode") == 0)
        {
            PlayerPrefs.SetString("CurrentBuildItem", "");
            plentingItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Build_mode", 1);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Collecting_mode", 0);
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
                if (buildingItems[j].count != 0)
                {
                    GameObject panel = Instantiate(BuildPanel);
                    panel.transform.SetParent(BuildItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform);
                    panel.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = buildingItems[j].Name;
                    panel.transform.GetChild(0).GetComponent<Image>().sprite = buildingItems[j].icon;
                    if (buildingItems[j].showCount == true)
                    {
                        panel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = buildingItems[j].count.ToString();
                    }
                    else
                    {
                        panel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "";
                    }
                    panel.transform.localScale = new Vector3(0.2824726f, -0.700887f, 2.530084f);
                    panel.GetComponent<PanelVariables>().type = buildingItems[j].Type;
                    //panel.GetComponent<Button>().onClick.AddListener(() => this.GetComponent<PanelVariables>().ActiveBuildItem(this.GetComponent<PanelVariables>().type));
                }
            }
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
            PlayerPrefs.SetInt("Collecting_mode", 0);
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
            PlayerPrefs.SetInt("Collecting_mode", 0);
            PlayerPrefs.SetInt("Plenting_mode", 1);
            BuildItemsPanel.SetActive(false);
            plentingItemsPanel.SetActive(true);
            inventory.SetActive(false);

            int Chailds = plentingItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.childCount;
            for (int i = 0; i < Chailds; i++)
            {
                Destroy(plentingItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).gameObject);
            }

            int seedsItem = seedsItems.Count;
            for (int j = 0; j < seedsItem; j++)
            {
                if (seedsItems[j].count != 0)
                {
                    GameObject panel = Instantiate(PlantPanel);
                    panel.transform.SetParent(plentingItemsPanel.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform);
                    panel.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = seedsItems[j].Name;
                    panel.transform.GetChild(0).GetComponent<Image>().sprite = seedsItems[j].icon;
                    if (seedsItems[j].showCount == true)
                    {
                        panel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = seedsItems[j].count.ToString();
                    }
                    else
                    {
                        panel.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "";
                    }
                    panel.transform.localScale = new Vector3(0.2824726f, -0.700887f, 2.530084f);
                    panel.GetComponent<PanelVariables>().type = seedsItems[j].Type;
                    //panel.GetComponent<Button>().onClick.AddListener(() => this.GetComponent<PanelVariables>().ActiveSeeds(this.GetComponent<PanelVariables>().type));
                }
            }
        }
        else
        {
            BuildItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            plentingItemsPanel.SetActive(false);
        }
    }

    public void OnCollectingMode()
    {
        if (PlayerPrefs.GetInt("Collecting_mode") == 0)
        {
            plentingItemsPanel.SetActive(false);
            BuildItemsPanel.SetActive(false);
            inventory.SetActive(false);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Collecting_mode", 1);
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

    public void DestroyMenuObject()
    {
        player.GetComponent<ReplaceObject>().MenuPanel.SetActive(false);
        player.GetComponent<ReplaceObject>().itemDialogPanel.SetActive(false);
        GameObject AddStartGround = player.GetComponent<createMarcer>().AddStartGround;
        player.GetComponent<createMarcer>().GroundXZ.Remove((player.GetComponent<createMarcer>().xToMenuController.ToString() + (player.GetComponent<createMarcer>().zToMenuController).ToString()));
        Destroy(player.GetComponent<ReplaceObject>().curentObject);
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
