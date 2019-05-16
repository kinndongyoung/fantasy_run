using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//Test

public class Test : MonoBehaviour
{
    public Item_Box ItemBox;

    private GameObject target;
    // Start is called befsore the first frame update
    void Start()
    {
        ItemBox.GetComponent<Item_Box>();
       // if(box_rotate.state == false)
       // this.gameObject.SetActive(true);
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemBox.state == false)
            this.gameObject.SetActive(false);

        
        if(Input.GetMouseButton(0))
        {

            if(EventSystem.current.IsPointerOverGameObject())
            {
                this.gameObject.SetActive(false);
            }

            
        }
    
      
        
    }
}
