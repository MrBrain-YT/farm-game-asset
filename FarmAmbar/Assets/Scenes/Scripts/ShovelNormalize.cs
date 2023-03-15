using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelNormalize : MonoBehaviour
{
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(hand.transform.position.x, hand.transform.position.y, hand.transform.position.z));
    }
}
