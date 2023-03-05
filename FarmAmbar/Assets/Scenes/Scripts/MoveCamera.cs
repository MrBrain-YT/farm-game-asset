using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 touch;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touch = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direction = touch - Camera.main.ScreenToViewportPoint(Input.mousePosition);
            GameObject.Find("camera").transform.position += new Vector3(direction.x, direction.z, direction.y);
        }
    }
}
