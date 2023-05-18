using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createMarcer : MonoBehaviour
{
    public GameObject Marcer;
    public GameObject TreeMarcer;
    public GameObject RockMarcer;
    public GameObject SeedMarcer;
    public GameObject DelTree;
    public GameObject DelRock;
    public GameObject AddStartGround;
    public GameObject GroundGalagramm;
    public GameObject GroundBuildPreModel;
    public float xToMenuController;
    public float zToMenuController;
    public List<string> GroundXZ;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("Inventory") == 0)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                if (Input.GetMouseButton(0))
                {
                    Ray ray5 = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit5;
                    if (Physics.Raycast(ray5, out hit5))
                    {
                        float PosX = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.x - hit5.point.x)) / 20);
                        float PosZ = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.z - hit5.point.z)) / 20);
                        float PosX2 = PosX * 20;
                        float PosZ2 = (PosZ * 20) + 20;
                        xToMenuController = AddStartGround.transform.position.x - PosX2;
                        zToMenuController = AddStartGround.transform.position.z - PosZ2;
                    }
                }
            }
            if (PlayerPrefs.GetInt("Build_mode") == 0 && PlayerPrefs.GetInt("Destroy_mode") == 1 && PlayerPrefs.GetInt("Move_mode") == 0 && PlayerPrefs.GetInt("Plenting_mode") == 0)
            {

                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    if (Input.GetMouseButton(0))
                    {
                        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                        RaycastHit hit2;
                        if (Physics.Raycast(ray2, out hit2))
                        {
                            float PosX = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.x - hit2.point.x)) / 20);
                            float PosZ = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.z - hit2.point.z)) / 20);
                            float PosX2 = PosX * 20;
                            float PosZ2 = (PosZ * 20) + 20;
                            if (hit2.collider.gameObject.tag == "build")
                            {
                                float x = AddStartGround.transform.position.x - PosX2;
                                float z = AddStartGround.transform.position.z - PosZ2;
                                GroundXZ.Remove((x).ToString() + (z).ToString());
                                Destroy(hit2.collider.gameObject.transform.parent.gameObject);
                            }
                        }
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit2;
                    if (Physics.Raycast(ray2, out hit2))
                    {
                        float PosX = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.x - hit2.point.x)) / 20);
                        float PosZ = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.z - hit2.point.z)) / 20);
                        float PosX2 = PosX * 20;
                        float PosZ2 = (PosZ * 20) + 20;
                        if (hit2.collider.gameObject.tag == "build")
                        {
                            float x = AddStartGround.transform.position.x - PosX2;
                            float z = AddStartGround.transform.position.z - PosZ2;
                            GroundXZ.Remove((x).ToString() + (z).ToString());
                            Destroy(hit2.collider.gameObject.transform.parent.gameObject);
                        }
                    }
                }
            }
            if (PlayerPrefs.GetInt("Build_mode") == 0 && PlayerPrefs.GetInt("Destroy_mode") == 0 && PlayerPrefs.GetInt("Move_mode") == 0 && PlayerPrefs.GetInt("Plenting_mode") == 0)
            {
                if (PlayerPrefs.GetInt("Build") == 1)
                {

                }
                else
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
                                        Destroy(GameObject.Find("WolkMarcer(Clone)"));
                                        Destroy(GameObject.Find("SeedMarcer(Clone)"));
                                        Instantiate(TreeMarcer, new Vector3(hit2.point.x, 100.4f, hit2.point.z), Quaternion.identity);
                                    }
                                    else
                                    {
                                        Destroy(GameObject.Find("RockMarker(Clone)"));
                                        Destroy(GameObject.Find("WolkMarcer(Clone)"));
                                        Destroy(GameObject.Find("Sphere(Clone)"));
                                        Destroy(GameObject.Find("SeedMarcer(Clone)"));
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
                                        Destroy(GameObject.Find("WolkMarcer(Clone)"));
                                        Destroy(GameObject.Find("Sphere(Clone)"));
                                        Destroy(GameObject.Find("SeedMarcer(Clone)"));
                                        Instantiate(RockMarcer, hit2.collider.gameObject.transform.position, Quaternion.identity);
                                    }
                                    else
                                    {
                                        Destroy(GameObject.Find("WolkMarcer(Clone)"));
                                        Destroy(GameObject.Find("Sphere(Clone)"));
                                        Destroy(GameObject.Find("RockMarker(Clone)"));
                                        Destroy(GameObject.Find("SeedMarcer(Clone)"));
                                        Instantiate(RockMarcer, hit2.collider.gameObject.transform.position, Quaternion.identity);
                                    }
                                }
                            }
                            else
                            {
                                if (Input.GetMouseButtonDown(1))
                                {
                                    GameObject obj = GameObject.Find("WolkMarcer(Clone)");
                                    if (obj == null)
                                    {
                                        Destroy(GameObject.Find("RockMarker(Clone)"));
                                        Destroy(GameObject.Find("Sphere(Clone)"));
                                        Destroy(GameObject.Find("SeedMarcer(Clone)"));
                                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                                        RaycastHit hit;
                                        if (Physics.Raycast(ray, out hit))
                                        {
                                            Vector3 contactPoint = hit.point;
                                            Instantiate(Marcer, new Vector3(contactPoint.x, 112.79f, contactPoint.z), Quaternion.identity);
                                        }
                                    }
                                    else
                                    {
                                        Destroy(GameObject.Find("RockMarker(Clone)"));
                                        Destroy(GameObject.Find("WolkMarcer(Clone)"));
                                        Destroy(GameObject.Find("Sphere(Clone)"));
                                        Destroy(GameObject.Find("SeedMarcer(Clone)"));
                                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                                        RaycastHit hit;
                                        if (Physics.Raycast(ray, out hit))
                                        {
                                            // Get the point of contact between the ray and the object
                                            Vector3 contactPoint = hit.point;

                                            // Do something with the contact point, such as log it to the console

                                            Instantiate(Marcer, new Vector3(contactPoint.x, 112.79f, contactPoint.z), Quaternion.identity);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (PlayerPrefs.GetInt("Build_mode") == 1 && PlayerPrefs.GetInt("Destroy_mode") == 0 && PlayerPrefs.GetInt("Move_mode") == 0 && PlayerPrefs.GetInt("Plenting_mode") == 0)
            {

                Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit2;
                if (Physics.Raycast(ray2, out hit2))
                {
                    if (hit2.transform.tag == "earth_1" || hit2.transform.tag == "Rock" || hit2.transform.tag == "Tree" || hit2.transform.tag == "build" || hit2.transform.tag == "Player")
                    {
                        Destroy(GameObject.Find("Groun_PreModel(Clone)"));
                    }
                    else
                    {
                        float PosX = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.x - hit2.point.x)) / 20);
                        float PosZ = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.z - hit2.point.z)) / 20);



                        float PosX2 = PosX * 20;
                        float PosZ2 = (PosZ * 20) + 20;

                        if (GameObject.Find("Groun_PreModel(Clone)") == null)
                        {
                            if (PlayerPrefs.GetString("CurrentBuildItem") == "Ground_1")
                            {
                                GameObject GO = Instantiate(GroundGalagramm, new Vector3(AddStartGround.transform.position.x - PosX2, 101, AddStartGround.transform.position.z - PosZ2), Quaternion.identity);
                                GO.transform.rotation = Quaternion.Euler(0, 0, 90);
                            }
                        }
                        else
                        {
                            GameObject.Find("Groun_PreModel(Clone)").transform.position = new Vector3(AddStartGround.transform.position.x - PosX2, 101, AddStartGround.transform.position.z - PosZ2);
                        }
                        if (Input.GetMouseButtonDown(1))
                        {
                            if (PlayerPrefs.GetString("CurrentBuildItem") == "Ground_1")
                            {
                                float x = AddStartGround.transform.position.x - PosX2;
                                float z = AddStartGround.transform.position.z - PosZ2;
                                if (GroundXZ.Contains((x).ToString() + (z).ToString()))
                                {
                                    Destroy(GameObject.Find("Groun_PreModel(Clone)"));
                                }
                                else
                                {
                                    GameObject Earth = Instantiate(GroundBuildPreModel, new Vector3(AddStartGround.transform.position.x - PosX2, 101, AddStartGround.transform.position.z - PosZ2), Quaternion.identity);
                                    Earth.transform.rotation = Quaternion.Euler(0, 0, 90);
                                    Earth.tag = "build";
                                    Earth.transform.GetChild(0).tag = "build";
                                    GroundXZ.Add((x).ToString() + (z).ToString());
                                }
                            }
                        }
                        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                        {
                            if (Input.GetMouseButton(0))
                            {
                                if (PlayerPrefs.GetString("CurrentBuildItem") == "Ground_1")
                                {
                                    if (hit2.transform.name == "Groun_PreBuild(Clone)" || hit2.transform.name == "ground_1(Clone)")
                                    {
                                        Destroy(GameObject.Find("Groun_PreModel(Clone)"));
                                    }
                                    else
                                    {
                                        float x = AddStartGround.transform.position.x - PosX2;
                                        float z = AddStartGround.transform.position.z - PosZ2;
                                        if (GroundXZ.Contains((x).ToString() + (z).ToString()))
                                        {
                                            Destroy(GameObject.Find("Groun_PreModel(Clone)"));
                                        }
                                        else
                                        {
                                            GameObject Earth = Instantiate(GroundBuildPreModel, new Vector3(AddStartGround.transform.position.x - PosX2, 101, AddStartGround.transform.position.z - PosZ2), Quaternion.identity);
                                            Earth.transform.rotation = Quaternion.Euler(0, 0, 90);
                                            Earth.tag = "build";
                                            Earth.transform.GetChild(0).tag = "build";
                                            GroundXZ.Add((x).ToString() + (z).ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (PlayerPrefs.GetInt("Build_mode") == 0 && PlayerPrefs.GetInt("Destroy_mode") == 0 && PlayerPrefs.GetInt("Move_mode") == 1 && PlayerPrefs.GetInt("Plenting_mode") == 0)
            {
                if (Input.GetMouseButton(0))
                {
                    Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit2;
                    if (Physics.Raycast(ray2, out hit2))
                    {
                        float PosX = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.x - hit2.point.x)) / 20);
                        float PosZ = Mathf.Floor((Mathf.Floor(AddStartGround.transform.position.z - hit2.point.z)) / 20);
                        float PosX2 = PosX * 20;
                        float PosZ2 = (PosZ * 20) + 20;
                        float x = AddStartGround.transform.position.x - PosX2;
                        float z = AddStartGround.transform.position.z - PosZ2;
                        this.GetComponent<ReplaceObject>().curentObject.transform.position = new Vector3(AddStartGround.transform.position.x - PosX2, 101, AddStartGround.transform.position.z - PosZ2);

                        if (GroundXZ.Contains((x).ToString() + (z).ToString()))
                        {

                        }
                        else
                        {
                            GroundXZ.Add((x).ToString() + (z).ToString());
                            this.GetComponent<ReplaceObject>().curentObject.transform.position = new Vector3(AddStartGround.transform.position.x - PosX2, 101, AddStartGround.transform.position.z - PosZ2);
                            PlayerPrefs.SetInt("Move_mode", 0);
                        }
                    }
                }
            }
            else if (PlayerPrefs.GetInt("Build_mode") == 0 && PlayerPrefs.GetInt("Destroy_mode") == 0 && PlayerPrefs.GetInt("Move_mode") == 0 && PlayerPrefs.GetInt("Plenting_mode") == 1)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    if (PlayerPrefs.GetString("CurrentSeed") == "Wheat")
                    {
                        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                        RaycastHit hit2;
                        if (Physics.Raycast(ray2, out hit2))
                        {
                            if (hit2.collider.tag == "earth_1")
                            {
                                Destroy(GameObject.Find("WolkMarcer(Clone)"));
                                Destroy(GameObject.Find("Sphere(Clone)"));
                                Destroy(GameObject.Find("SeedMarcer(Clone)"));
                                hit2.collider.gameObject.transform.parent.gameObject.tag = "SeedMarker";
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (Input.GetMouseButton(0))
                    {
                        if (PlayerPrefs.GetString("CurrentSeed") == "Wheat")
                        {
                            Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                            RaycastHit hit2;
                            if (Physics.Raycast(ray2, out hit2))
                            {
                                if (hit2.collider.tag == "earth_1")
                                {
                                    Destroy(GameObject.Find("WolkMarcer(Clone)"));
                                    Destroy(GameObject.Find("Sphere(Clone)"));
                                    Destroy(GameObject.Find("SeedMarcer(Clone)"));
                                    hit2.collider.gameObject.transform.parent.gameObject.tag = "SeedMarker";

                                }
                            }
                        }
                    }
                }
            }

        }
    }
}