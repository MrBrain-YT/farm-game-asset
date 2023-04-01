using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject BuildItemsPanel;
    public GameObject plentingItemsPanel;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Move_mode", 0);
        PlayerPrefs.SetInt("Plenting_mode", 0);
        PlayerPrefs.SetInt("Build_mode", 0);
        PlayerPrefs.SetString("CurrentBuildItem", "");
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
            PlayerPrefs.SetInt("Plenting_mode", 0);
            BuildItemsPanel.SetActive(true);
        }
        else
        {
            plentingItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Plenting_mode", 0);
            BuildItemsPanel.SetActive(false);
            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
        }
    }
    public void OnDestroyMode()
    {
        if (PlayerPrefs.GetInt("Destroy_mode") == 0)
        {
            plentingItemsPanel.SetActive(false);
            BuildItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Destroy_mode", 1);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
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
            PlayerPrefs.SetInt("Destroy_mode", 0);
            PlayerPrefs.SetInt("Build_mode", 0);
            PlayerPrefs.SetInt("Move_mode", 0);
            PlayerPrefs.SetInt("Plenting_mode", 1);
            BuildItemsPanel.SetActive(false);
            plentingItemsPanel.SetActive(true);
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
