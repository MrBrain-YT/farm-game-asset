using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardCameraMovement : MonoBehaviour
{
    public float m_Speed = 0.5f;
    public GameObject ItemDialogPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Inventory") == 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                m_Speed = 2;
            }
            else
            {
                m_Speed = 0.5f;
            }
            if (Input.GetKey(KeyCode.W))
            {
                ItemDialogPanel.SetActive(false);
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - m_Speed, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                ItemDialogPanel.SetActive(false);
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - m_Speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                ItemDialogPanel.SetActive(false);
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + m_Speed, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                ItemDialogPanel.SetActive(false);
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z + m_Speed);
            }
        }
    }
}
