using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemEffet : MonoBehaviour
{
    public SWS.splineMove spline_Move;
    private Item_Box Item_Box;
    private GameObject taget;
    [HideInInspector]
    public bool Speed1_state, Speed2_state, Ignore_state;

    public bool State;

    void Start()
    {
        State = false;
        spline_Move = GameObject.FindGameObjectWithTag("Player").GetComponent<SWS.splineMove>();
        Item_Box = FindObjectOfType<Item_Box>();
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
    //122 55 109
    void Update()
    {
        Debug.Log("Effet state = " + Speed1_state);
        Debug.Log("Effet state = " + Speed2_state);
        Debug.Log("Effet state = " + Ignore_state);
        Debug.Log("Item_Box.Speed1_state = " + Item_Box.Speed1_state);
        Debug.Log("Item_Box.Speed2_state = " + Item_Box.Speed2_state);
        Debug.Log("Item_Box.Ignore_state = " + Item_Box.Ignore_state);
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
                    State = true;
                }
                if (Item_Box.Speed2_state == true)
                {
                    State = true;
                }
                if (Item_Box.Ignore_state == true)
                {
                    State = true;
                }
                this.gameObject.SetActive(false);
            }
        }
    }
}
