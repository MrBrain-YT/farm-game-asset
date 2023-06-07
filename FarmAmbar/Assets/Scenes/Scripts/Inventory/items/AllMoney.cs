using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AllMoney : MonoBehaviour
{
    public MoneyCount AllPlayerMoney;
    private GameObject Money;
    // Start is called before the first frame update
    void Start()
    {
        Money = GameObject.Find("MoneyCount");
    }

    // Update is called once per frame
    void Update()
    {
        Money.transform.GetComponent<TextMeshProUGUI>().text = AllPlayerMoney.count.ToString();
    }
}
