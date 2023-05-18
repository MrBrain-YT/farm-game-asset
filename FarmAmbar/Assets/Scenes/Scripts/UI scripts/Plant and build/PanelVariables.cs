using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelVariables : MonoBehaviour
{
    public string type;

    public void ActiveBuildItem()
    {
        PlayerPrefs.SetString("CurrentBuildItem", type);
    }

    public void ActiveSeeds()
    {
        PlayerPrefs.SetString("CurrentSeed", type);
    }
}
