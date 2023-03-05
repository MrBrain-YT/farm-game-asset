using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject targetObject;
    public float moveSpeed = 200f;

    private Transform characterTransform;
    private Transform targetTransform;
    // Start is called before the first frame update
    void Start()
    {
        characterTransform = transform.GetComponent<Transform>();
        targetTransform = GameObject.Find("Cylinder(Clone)").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        targetTransform = GameObject.Find("Cylinder(Clone)").GetComponent<Transform>();
        float distance = Vector3.Distance(characterTransform.position, targetTransform.position);

        // Move the character towards the target object if it is not yet close enough
        if (distance > 0.1f)
        {
            print(distance);
            Vector3 direction = (targetTransform.position - characterTransform.position).normalized;
            characterTransform.position += direction * moveSpeed * Time.deltaTime;
            //Destroy(GameObject.Find("Cylinder(Clone)"));
        }
        else
        {
            Destroy(GameObject.Find("Cylinder(Clone)"));
        }
    }
}
