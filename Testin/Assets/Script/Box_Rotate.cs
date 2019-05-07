using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Box
public class Box_Rotate : MonoBehaviour
{
    //public float Xspeed,Yspeed = -100f,Zspeed;
    public float Yspeed = 70;


    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, Time.deltaTime * Yspeed, 0, Space.World);
        //this.transform.Rotate(new Vector3(0, 0, 70) * Time.deltaTime);
        //transform.Rotate(Time.deltaTime*Xspeed, Time.deltaTime*Yspeed, Time.deltaTime*Zspeed, Space.World);
        
       
    }
    void OnTriggerEnter(Collider other)
    {

        //플레이어가 아이템에 닿았을 때 
        if(other.gameObject.tag == "Player")
        {
             //other.gameObject.SetActive(false);
            Destroy(gameObject);
            
             //event
        }
    }

}
//30.67 3.58 63.94
//34.33 13.09 -98.47
       // 10.48
//72 -7 16