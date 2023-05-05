using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningWood : MonoBehaviour
{
    // Start is called before the first frame update
    public int timer = 10;
    public int time = 0;
    public GameObject Axe;
    private GameObject Tree;
    public Animator Anim;
    public MaterialsItems tree;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("GetWood") == 1)
        {
            if (time == timer * 60)
            {
                Tree = this.GetComponent<createMarcer>().DelTree;
                Destroy(Tree);
                Anim.SetFloat("GetWood", 0);
                Axe.SetActive(false);
                PlayerPrefs.SetInt("GetWood", 0);
                Destroy(GameObject.Find("Sphere(Clone)"));
                tree.count += 1;
                GameObject.Find("ObjectsVariable").GetComponent<Inventory>().RefreshInventory();
            }
            else
            {
                time = time + 1;
            }
        }
    }
}
