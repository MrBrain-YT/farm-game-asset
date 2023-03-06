using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createMarcer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Marcer;
    public GameObject TreeMarcer;
    public GameObject DelTree;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit2;
        if (Physics.Raycast(ray2, out hit2))
        {
            if (hit2.collider.gameObject.name == "Tree")
            {
                DelTree = hit2.collider.gameObject;
                if (Input.GetMouseButtonDown(1))
                {
                    GameObject obj = GameObject.Find("Sphere(Clone)");
                    if (obj == null)
                    {
                        Destroy(GameObject.Find("Cylinder(Clone)"));
                        Instantiate(TreeMarcer, new Vector3(hit2.point.x, 100.4f, hit2.point.z), Quaternion.identity);
                    }
                    else
                    {
                        Destroy(GameObject.Find("Cylinder(Clone)"));
                        Destroy(GameObject.Find("Sphere(Clone)"));
                        Instantiate(TreeMarcer, new Vector3(hit2.point.x, 100.4f, hit2.point.z), Quaternion.identity);
                    }
                }
            }
            else
            {
                //Transform targetTransform = GameObject.Find("Cylinder(Clone)").GetComponent<Transform>();
                //GameObject.Find("Farmer").transform.LookAt(new Vector3(targetTransform.position.x, targetTransform.position.y - 11f, targetTransform.position.z));
                if (Input.GetMouseButtonDown(1))
                {
                    GameObject obj = GameObject.Find("Cylinder(Clone)");
                    if (obj == null)
                    {
                        Destroy(GameObject.Find("Sphere(Clone)"));
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            // Get the point of contact between the ray and the object
                            Vector3 contactPoint = hit.point;

                            // Do something with the contact point, such as log it to the console

                            Debug.Log("Contact point: " + contactPoint);
                            Instantiate(Marcer, new Vector3(contactPoint.x, 112.79f, contactPoint.z), Quaternion.identity);
                        }
                    }
                    else
                    {
                        Destroy(GameObject.Find("Cylinder(Clone)"));
                        Destroy(GameObject.Find("Sphere(Clone)"));
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            // Get the point of contact between the ray and the object
                            Vector3 contactPoint = hit.point;

                            // Do something with the contact point, such as log it to the console

                            Debug.Log("Contact point: " + contactPoint);
                            Instantiate(Marcer, new Vector3(contactPoint.x, 112.79f, contactPoint.z), Quaternion.identity);
                        }
                    }
                }
            }
        }
    }
}

