using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planting : MonoBehaviour
{
    public int timer = 10;
    public int time = 0;
    public GameObject SeedPlant;
    private GameObject Ground;
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ground = this.GetComponent<PlayerMovement>().SeedPlant;
        if (PlayerPrefs.GetInt("Seeding") == 1)
        {
            if (time == timer * 60)
            {
                GameObject Earth = Instantiate(SeedPlant, new Vector3(Ground.transform.position.x - 20, 99, Ground.transform.position.z), Quaternion.identity);
                Earth.transform.rotation = new Quaternion(0, 0, -90, 90);
                Destroy(Ground);
                time = time + 1;
                Anim.SetFloat("Seeding", 0);
            }
            else if (time == 601)
            {

            }
            else
            {
                time = time + 1;
            }
        }
    }
}
