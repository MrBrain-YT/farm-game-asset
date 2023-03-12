using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Build_mode", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBuildMode()
    {
        PlayerPrefs.SetInt("Build_mode", 1);
    }
}
