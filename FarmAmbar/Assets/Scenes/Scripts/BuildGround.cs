using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildGround : MonoBehaviour
{
    public GameObject Shovel;
    public GameObject GroundBuild;
    private GameObject Ground;
    public Animator Anim;
    public int timer = 10;
    public int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("BuildGround") == 1)
        {
            if (time == timer * 60)
            {
                GameObject Build = this.GetComponent<PlayerMovement>().Build;
                GameObject Earth = Instantiate(GroundBuild, Build.transform.position, Quaternion.identity);
                Earth.transform.rotation = Quaternion.Euler(0, 0, 90);
                Earth.tag = "earth_1";
                Earth.transform.GetChild(0).tag = "earth_1";
                Destroy(Build);
                Anim.SetFloat("BuildGround", 0);
                Shovel.SetActive(false);
                PlayerPrefs.SetInt("BuildGround", 0);
                time = time + 1;
            }
            else
            {
                time = time + 1;
            }
        }
    }
}
