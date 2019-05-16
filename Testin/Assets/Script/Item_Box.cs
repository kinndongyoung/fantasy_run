using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Box
public class Item_Box : MonoBehaviour
{
    //public float Xspeed,Yspeed = -100f,Zspeed;
    public float Yspeed = 70;
    public int iRandom;// = Random.Range(0 , 2);
    public GameObject Item, Item1, Item2;

    public bool state;
    // Update is called once per frame
    private void Start()
    {
        Item = GameObject.FindGameObjectWithTag("Item");
        Item1 = GameObject.FindGameObjectWithTag("Item1");
        Item2 = GameObject.FindGameObjectWithTag("Item2");
       
    }

    void Update()
    {
        state = false;
        this.transform.Rotate(0, Time.deltaTime * Yspeed, 0, Space.World);
        //this.transform.Rotate(new Vector3(0, 0, 70) * Time.deltaTime);
        //transform.Rotate(Time.deltaTime*Xspeed, Time.deltaTime*Yspeed, Time.deltaTime*Zspeed, Space.World);
        
       
    }
    void OnTriggerEnter(Collider other)
    {
        iRandom = Random.Range(0, 5);
        //플레이어가 아이템에 닿았을 때 
        if (other.gameObject.tag == "Player")
        {

            
            //Item.gameObject.SetActive(true);
            state = true;
            if (iRandom == 1 || iRandom == 3)
                Item1.gameObject.SetActive(true);
            else if (iRandom == 0 || iRandom == 4)
                Item.gameObject.SetActive(true);
            else if (iRandom == 2 || iRandom == 5)
                Item2.gameObject.SetActive(true);
            Destroy(gameObject);

            //gameobject.setactive(false);
            //event (아이템 생성)

        }
    }

}
//30.67 3.58 63.94
//34.33 13.09 -98.47
       // 10.48
//72 -7 16