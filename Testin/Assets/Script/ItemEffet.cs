using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemEffet : MonoBehaviour
{
    public SWS.splineMove spline_Move;
    public Item_Box Item_Box;
    private GameObject taget;
    [HideInInspector]
    public bool Speed1_state, Speed2_state, Ignore_state;

    void Start()
    {

        spline_Move = GameObject.FindGameObjectWithTag("Player").GetComponent<SWS.splineMove>();
        Item_Box.GetComponent<Item_Box>();
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Item_Box.Speed1_state == false)
            this.gameObject.SetActive(false);
        if (Item_Box.Speed2_state == false)
            this.gameObject.SetActive(false);
        if (Item_Box.Ignore_state == false)
            this.gameObject.SetActive(false);

        if (Item_Box.Speed1_state == true)
        {
            this.gameObject.SetActive(true);
        }
        if (Item_Box.Speed2_state == true)
        {
            this.gameObject.SetActive(true);
        }
        if (Item_Box.Ignore_state == true)
        {
            this.gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(EventSystem.current.IsPointerOverGameObject())
            {
                if (Item_Box.Speed1_state == true)
                {
                    Speed1_state = true;
                }
                if (Item_Box.Speed2_state == true)
                {
                    Speed2_state = true;
                }
                if (Item_Box.Ignore_state == true)
                {
                    Ignore_state = true;
                }
                this.gameObject.SetActive(false);
            }
        }
    }
}
