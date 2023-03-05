using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YposPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float PosX = transform.position.x;
        float PosZ = transform.position.z;
        transform.position = new Vector3(PosX, 100.1f, PosZ);
    }
}
