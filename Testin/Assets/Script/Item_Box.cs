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
    public GameObject Speed_Item1, Speed_Item2, Igonore_Item;

    public bool Speed1_state, Speed2_state, Igonore_state;
    // Update is called once per frame
    private void Start()
    {
        Speed_Item1 = GameObject.FindGameObjectWithTag("Item");
        Igonore_Item = GameObject.FindGameObjectWithTag("Item1");
        Speed_Item2 = GameObject.FindGameObjectWithTag("Item2");
       
    }

    void Update()
    {
        Speed1_state = false;
        Speed2_state = false;
        Igonore_state = false;
        this.transform.Rotate(0, Time.deltaTime * Yspeed, 0, Space.World);
        //this.transform.Rotate(new Vector3(0, 0, 70) * Time.deltaTime);
        //transform.Rotate(Time.deltaTime*Xspeed, Time.deltaTime*Yspeed, Time.deltaTime*Zspeed, Space.World);
        
       
    }
    void OnTriggerEnter(Collider other)
    {
        iRandom = Random.Range(0, 1);
        //플레이어가 아이템에 닿았을 때   
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(ItemCheck());
                Destroy(gameObject);

            //gameobject.setactive(false);
            //event (아이템 생성)

        }
    }

    IEnumerator ItemCheck()
    {
      
        if (iRandom == 1 || iRandom == 3)
        {
            Speed_Item1.gameObject.SetActive(true);
            Speed1_state = true;
        }
        else if (iRandom == 0 || iRandom == 4)
        {
            Speed_Item2.gameObject.SetActive(true);
            Speed2_state = true;
        }
        else if (iRandom == 2 || iRandom == 5)
        {
            Igonore_Item.gameObject.SetActive(true);
            Igonore_state = true;
        }
        yield return new WaitForSeconds(0.5f);
    }

}
//30.67 3.58 63.94
//34.33 13.09 -98.47
       // 10.48
//72 -7 16