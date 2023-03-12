using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createMarcer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Marcer;
    public GameObject TreeMarcer;
    public GameObject RockMarcer;
    public GameObject DelTree;
    public GameObject DelRock;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Build_mode") == 0)
        {


            Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;
            if (Physics.Raycast(ray2, out hit2))
            {
                if (GameObject.Find("Sphere(Clone)") == null && GameObject.Find("RockMarker(Clone)") == null && PlayerPrefs.GetInt("GetWood") == 0 && PlayerPrefs.GetInt("GetRock") == 0)
                {
                    if (hit2.collider.gameObject.tag == "Tree")
                    {
                        DelTree = hit2.collider.gameObject;
                        if (Input.GetMouseButtonDown(1))
                        {
                            Destroy(GameObject.Find("RockMarker(Clone)"));
                            GameObject obj = GameObject.Find("Sphere(Clone)");
                            if (obj == null)
                            {
                                Destroy(GameObject.Find("RockMarker(Clone)"));
                                Destroy(GameObject.Find("Cylinder(Clone)"));
                                Instantiate(TreeMarcer, new Vector3(hit2.point.x, 100.4f, hit2.point.z), Quaternion.identity);
                            }
                            else
                            {
                                Destroy(GameObject.Find("RockMarker(Clone)"));
                                Destroy(GameObject.Find("Cylinder(Clone)"));
                                Destroy(GameObject.Find("Sphere(Clone)"));
                                Instantiate(TreeMarcer, new Vector3(hit2.point.x, 100.4f, hit2.point.z), Quaternion.identity);
                            }
                        }
                    }
                    else if (hit2.collider.gameObject.tag == "Rock")
                    {
                        DelRock = hit2.collider.gameObject;
                        if (Input.GetMouseButtonDown(1))
                        {
                            GameObject obj = GameObject.Find("RockMarker(Clone)");
                            if (obj == null)
                            {
                                Destroy(GameObject.Find("Cylinder(Clone)"));
                                Destroy(GameObject.Find("Sphere(Clone)"));
                                Instantiate(RockMarcer, hit2.collider.gameObject.transform.position, Quaternion.identity);
                            }
                            else
                            {
                                Destroy(GameObject.Find("Cylinder(Clone)"));
                                Destroy(GameObject.Find("Sphere(Clone)"));
                                Destroy(GameObject.Find("RockMarker(Clone)"));
                                Instantiate(RockMarcer, hit2.collider.gameObject.transform.position, Quaternion.identity);
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
                                Destroy(GameObject.Find("RockMarker(Clone)"));
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
                                Destroy(GameObject.Find("RockMarker(Clone)"));
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
    }
}

