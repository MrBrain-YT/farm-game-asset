using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDialogPanelFals : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        //Вывести имя игрового объекта , по которому щелкнули
        this.gameObject.SetActive(false);
    }
}