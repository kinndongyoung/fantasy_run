using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Box_Rotate box_rotate;

    // Start is called befsore the first frame update
    void Start()
    {
        box_rotate.GetComponent<Box_Rotate>();
       // if(box_rotate.state == false)
       // this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
            if (box_rotate.state == false)
            this.gameObject.SetActive(false);
            


    }
}
