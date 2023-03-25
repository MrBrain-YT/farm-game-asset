using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject BuildItemsPanel;
    // Start is called before the first frame update
    void Start()
    {
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
            PlayerPrefs.SetInt("Build_mode", 1);
            PlayerPrefs.SetInt("Destroy_mode", 0);
            BuildItemsPanel.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("Build_mode", 0);
            BuildItemsPanel.SetActive(false);
            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
        }
    }
    public void OnDestroyMode()
    {
        if (PlayerPrefs.GetInt("Destroy_mode") == 0)
        {
            PlayerPrefs.SetInt("Destroy_mode", 1);
            PlayerPrefs.SetInt("Build_mode", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Destroy_mode", 0);
            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
        }
    }

    public void ActiveBuildGround()
    {
        PlayerPrefs.SetString("CurrentBuildItem", "Ground_1");
    }
}
