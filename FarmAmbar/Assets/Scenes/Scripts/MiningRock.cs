using UnityEngine;

public class MiningRock : MonoBehaviour
{
    // Start is called before the first frame update
    public int timer = 10;
    public int time = 0;
    public GameObject PixeAxe;
    private GameObject delRock;
    public Animator Anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("GetRock") == 1)
        {
            if (time == timer * 60)
            {

                delRock = this.GetComponent<createMarcer>().DelRock;
                Destroy(delRock);
                Anim.SetFloat("GetRock", 0);
                PixeAxe.SetActive(false);
                PlayerPrefs.SetInt("GetRock", 0);
                

            }
            else
            {
                time = time + 1;
            }
        }
    }
}
