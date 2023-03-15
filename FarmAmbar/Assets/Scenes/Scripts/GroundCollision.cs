using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.tag == "Tree")
        {
            print(myCollision.gameObject);
            Destroy(this.gameObject);
        }
        else if (myCollision.gameObject.tag == "Rock")
        {
            print(myCollision.gameObject);
            Destroy(this.gameObject);
        }
        else if (myCollision.gameObject.tag == "earth_0")
        {
            print(myCollision.gameObject);
            Destroy(this.gameObject);
        }
        else if (myCollision.gameObject.tag == "earth_1")
        {
            print(myCollision.gameObject);
            Destroy(this.gameObject);
        }
        else if (myCollision.gameObject.tag == "build")
        {
            print(myCollision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
