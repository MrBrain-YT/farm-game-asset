using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceObject : MonoBehaviour
{
    public GameObject itemDialogPanel;
    public GameObject MenuPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if(Input.GetMouseButtonDown(0))
            { 
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "earth_1")
                    {
                        MenuPanel.GetComponent<Transform>().position = Input.mousePosition;
                        itemDialogPanel.SetActive(true);
                        MenuPanel.SetActive(true);
                    }
                }
            }
        }
    }
}
