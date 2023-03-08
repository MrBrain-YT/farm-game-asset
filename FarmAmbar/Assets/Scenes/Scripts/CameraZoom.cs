using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private int MaxScroll = 11;
    private int MinScroll = 0;
    private int CurentScroll = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the amount the mouse wheel has been scrolled
        float scrollDelta = Input.mouseScrollDelta.y;

        // Zoom the camera in or out depending on the scroll direction
        if (scrollDelta < 0)
        {
            if (CurentScroll < MaxScroll)
            {
                transform.position = new Vector3(transform.position.x + 10f, transform.position.y + 10f, transform.position.z);
                CurentScroll ++;
            }
        }
        else if (scrollDelta > 0)
        {
            if (CurentScroll > MinScroll)
            {
                transform.position = new Vector3(transform.position.x - 10f, transform.position.y - 10f, transform.position.z);
                CurentScroll--;
            }
        }
    }
}
