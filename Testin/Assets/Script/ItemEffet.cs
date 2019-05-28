using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemEffet : MonoBehaviour
{
    private SWS.splineMove spline_Move;
    public Item_Box Item_Box;
    private GameObject taget;
    
    public bool bState;

    void Start()
    {
        bState = false;
        spline_Move = GameObject.FindGameObjectWithTag("Player").GetComponent<SWS.splineMove>();
        Item_Box.GetComponent<Item_Box>();
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Item_Box.state == false)
            this.gameObject.SetActive(false);

        if(Input.GetMouseButton(0))
        {
            if(EventSystem.current.IsPointerOverGameObject())
            {
                bState = true;
                this.gameObject.SetActive(false);
            }
        }
    }
}
