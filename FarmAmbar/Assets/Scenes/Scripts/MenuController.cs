using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject BuildItemsPanel;
    public GameObject player;
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
            BuildItemsPanel.SetActive(false);
            PlayerPrefs.SetInt("Destroy_mode", 1);
            PlayerPrefs.SetInt("Build_mode", 0);
            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
        }
        else
        {
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
        //RaycastHit hit2 = player.GetComponent<createMarcer>().hit5;
        /*float PosX = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.x - hit2.point.x)) / 20);
        float PosZ = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.z - hit2.point.z)) / 20);
        float PosX2 = PosX * 20;
        float PosZ2 = (PosZ * 20) + 20;
        float x = AddStartGround.transform.position.x - PosX2;
        float z = AddStartGround.transform.position.z - PosZ2;
        print(x);*/
        player.GetComponent<createMarcer>().GroundXZ.Remove((player.GetComponent<createMarcer>().xToMenuController.ToString() + (player.GetComponent<createMarcer>().zToMenuController).ToString()));
        Destroy(player.GetComponent<ReplaceObject>().curentObject);
    }

    public void ActiveBuildGround()
    {
        PlayerPrefs.SetString("CurrentBuildItem", "Ground_1");
    }
}
