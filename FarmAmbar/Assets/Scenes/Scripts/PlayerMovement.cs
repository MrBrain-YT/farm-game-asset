using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject targetObject;
    public float moveSpeed = 5f;
    public Animator Anim;
    public GameObject Axe;
    public GameObject PickAxe;
    public GameObject GroundBuild;
    private Transform characterTransform;
    private Transform targetTransform;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("GetRock", 0);
        PlayerPrefs.SetInt("GetWood", 0);
        characterTransform = transform.GetComponent<Transform>();
        targetTransform = GameObject.Find("Cylinder(Clone)").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        Anim.SetFloat("GetWood", 0);
        GameObject MoveMarker = GameObject.Find("Cylinder(Clone)");
        if (MoveMarker != null)
        {
            targetTransform = GameObject.Find("Cylinder(Clone)").GetComponent<Transform>();
            float distance = Vector3.Distance(characterTransform.position, new Vector3(targetTransform.position.x, 100.1f, targetTransform.position.z));

            // Move the character towards the target object if it is not yet close enough
            if (distance > 2f)
            {
                transform.LookAt(new Vector3(targetTransform.position.x, targetTransform.position.y - 12.5f, targetTransform.position.z));
                //transform.LookAt(targetTransform);
                Anim.SetFloat("Wolk", 1f);
                print(distance);
                Vector3 direction = (targetTransform.position - characterTransform.position).normalized;
                characterTransform.position += direction * moveSpeed * Time.deltaTime;
                //Destroy(GameObject.Find("Cylinder(Clone)"));
            }
            else
            {
                Anim.SetFloat("Wolk", 0f);
                Destroy(GameObject.Find("Cylinder(Clone)"));
            }
        }
        GameObject TreeMarker = GameObject.Find("Sphere(Clone)");
        if (TreeMarker != null)
        {
            Transform targetTransformTree = GameObject.Find("Sphere(Clone)").GetComponent<Transform>();
            float distance2 = Vector3.Distance(characterTransform.position, new Vector3(targetTransformTree.position.x, 100.1f, targetTransformTree.position.z));

            // Move the character towards the target object if it is not yet close enough
            if (distance2 > 5.5f)
            {
                this.GetComponent<MiningWood>().time = 0;
                transform.LookAt(new Vector3(targetTransformTree.position.x, targetTransformTree.position.y - 0.5f, targetTransformTree.position.z));
                //transform.LookAt(targetTransform);
                Anim.SetFloat("Wolk", 1f);
                print(distance2);
                Vector3 direction2 = (targetTransformTree.position - characterTransform.position).normalized;
                characterTransform.position += direction2 * moveSpeed * Time.deltaTime;
                //Destroy(GameObject.Find("Cylinder(Clone)"));
            }
            else
            {
                
                PlayerPrefs.SetInt("GetWood", 1);
                Anim.SetFloat("Wolk", 0f);
                Axe.SetActive(true);
                Anim.SetFloat("GetWood", 1f);
                
            }
        }
        GameObject RockMarker = GameObject.Find("RockMarker(Clone)");
        if (RockMarker != null)
        {
            Transform targetTransformRock = GameObject.Find("RockMarker(Clone)").GetComponent<Transform>();
            float distance3 = Vector3.Distance(characterTransform.position, new Vector3(targetTransformRock.position.x, 100.1f, targetTransformRock.position.z));
            //print(distance3 + "  123");
            // Move the character towards the target object if it is not yet close enough
            if (distance3 > 12.5f)
            {
                        
                transform.LookAt(new Vector3(targetTransformRock.position.x, targetTransformRock.position.y - 0.5f, targetTransformRock.position.z));
                //transform.LookAt(targetTransform);
                Anim.SetFloat("Wolk", 1f);
                Vector3 direction3 = (targetTransformRock.position - characterTransform.position).normalized;
                characterTransform.position += direction3 * moveSpeed * Time.deltaTime;
                //Destroy(GameObject.Find("Cylinder(Clone)"));
            }
            else
            {
                this.GetComponent<MiningRock>().time = 0;
                PlayerPrefs.SetInt("GetRock", 1);
                Anim.SetFloat("Wolk", 0f);
                PickAxe.SetActive(true);
                Anim.SetFloat("GetRock", 1f);
                Destroy(GameObject.Find("RockMarker(Clone)"));
            }
        }
        GameObject Build  = GameObject.FindGameObjectWithTag("build");
        print(Build);
        if (Build != null)
        {
            Transform targetTransformBuild = Build.GetComponent<Transform>();
            float distance3 = Vector3.Distance(characterTransform.position, new Vector3(targetTransformBuild.position.x, 100.1f, targetTransformBuild.position.z));
            //print(distance3 + "  123");
            // Move the character towards the target object if it is not yet close enough
            if (distance3 > 3f)
            {

                transform.LookAt(new Vector3(targetTransformBuild.position.x, targetTransformBuild.position.y - 0.5f, targetTransformBuild.position.z));
                //transform.LookAt(targetTransform);
                Anim.SetFloat("Wolk", 1f);
                Vector3 direction3 = (targetTransformBuild.position - characterTransform.position).normalized;
                characterTransform.position += direction3 * moveSpeed * Time.deltaTime;
                //Destroy(GameObject.Find("Cylinder(Clone)"));
            }
            else
            {
                Anim.SetFloat("Wolk", 0f);
                GameObject Earth = Instantiate(GroundBuild, Build.transform.position , Quaternion.identity);
                Earth.transform.rotation = Quaternion.Euler(0, 0, 90);
                Earth.tag = "earth_1";
                Earth.transform.GetChild(0).tag = "earth_1";
                Destroy(Build);
            }
        }
    }
}
