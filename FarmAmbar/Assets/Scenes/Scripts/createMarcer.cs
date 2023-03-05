using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createMarcer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Marcer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = GameObject.Find("Cylinder(Clone)");
            if (obj == null)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    // Get the point of contact between the ray and the object
                    Vector3 contactPoint = hit.point;

                    // Do something with the contact point, such as log it to the console

                    Debug.Log("Contact point: " + contactPoint);
                    Instantiate(Marcer, new Vector3(contactPoint.x, 110.6f, contactPoint.z), Quaternion.identity);
                }
            }
        }
        if (Input.GetMouseButton(0))
        {
            
            
        }
    }
}
