using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceObject : MonoBehaviour
{
    public GameObject itemDialogPanel;
    public GameObject MenuPanel;
    public GameObject curentObject;
    public RaycastHit hit;
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
                        curentObject = hit.transform.gameObject.transform.parent.gameObject;
                        itemDialogPanel.SetActive(true);
                        MenuPanel.GetComponent<Transform>().position = Camera.main.WorldToScreenPoint(new Vector3(hit.transform.position.x - 30, hit.transform.position.y, hit.transform.position.z + 10));
                        MenuPanel.SetActive(true);
                    }
                }
            }
        }
    }
}
