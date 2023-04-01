using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growthWheat_1 : MonoBehaviour
{
    public float Timer = 600;
    private GameObject objectsVariables;
    // Start is called before the first frame update
    void Start()
    {
        objectsVariables = GameObject.Find("ObjectsVariable");
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= 0)
        {
            GameObject Earth = Instantiate(objectsVariables.GetComponent<ObjectsVariable>().GroundWheat_1, this.transform.position, Quaternion.identity);
            Earth.transform.rotation = this.transform.rotation;
            Destroy(this.transform.gameObject);
        }
        else
        {
            Timer -= 1;
        }
    }
}
