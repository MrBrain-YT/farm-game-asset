using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 touch;
    public int CheckMultiBuilding = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetMouseButtonDown(0))
            {
                CheckMultiBuilding = 1;
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            CheckMultiBuilding = 0;
            touch = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {

        }

        else if (Input.GetMouseButton(0))
        {
            CheckMultiBuilding = 0;
            Vector3 direction = touch - Camera.main.ScreenToViewportPoint(Input.mousePosition);
            GameObject.Find("camera").transform.position += new Vector3(direction.x, direction.z, direction.y);
        }

    }
}
