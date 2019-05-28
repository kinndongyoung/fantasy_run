using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeManager : MonoBehaviour
{
    enum ATTRIBUTE
    {
        eSpace = 1,
        eFire     ,
        ePeace    ,
        eForest   ,
    }

    public Animator Animator_Player;

    private GameObject AttributeObj_Space;
    private GameObject AttributeObj_Fire;
    private GameObject AttributeObj_Peace;
    private GameObject AttributeObj_Forest;
    
    private SWS.splineMove spline_move;
    private int Rand_Attribute;    

    void Awake()
    {
        Animator_Player = GameObject.Find("avatar1").GetComponent<Animator>();
        AttributeObj_Space = GameObject.Find("Attribute_Space");
        AttributeObj_Fire = GameObject.Find("Attribute_Fire");
        AttributeObj_Peace = GameObject.Find("Attribute_Peace");
        AttributeObj_Forest = GameObject.Find("Attribute_Forest");
        
        spline_move = GameObject.Find("avatar1").GetComponent<SWS.splineMove>();

        AttributeObj_Space.SetActive(false);
        AttributeObj_Fire.SetActive(false);
        AttributeObj_Peace.SetActive(false);
        AttributeObj_Forest.SetActive(false);
    }

    void Start()
    {
        Rand_Attribute = 1;//Random.Range(1, 5);

        switch(Rand_Attribute)
        {
            case (int)ATTRIBUTE.eSpace:
            {
                AttributeObj_Space.SetActive(true);
                AttributeFunc_Space();
            }
            break;
            case (int)ATTRIBUTE.eFire:
            {
                AttributeObj_Fire.SetActive(true);
                AttributeFunc_Fire();
            }
            break;
            case (int)ATTRIBUTE.ePeace:
            {
                AttributeObj_Peace.SetActive(true);
                AttributeFunc_Peace();
            }
            break;
            case (int)ATTRIBUTE.eForest:
            {
                AttributeObj_Forest.SetActive(true);
                AttributeFunc_Forest();
            }
            break;
        }
    }

    void AttributeFunc_Space()
    {

    }

    void AttributeFunc_Fire()
    {
       // Fire 속성 수치 조정 부분
       spline_move.speed = 30.0f;
    }

    void AttributeFunc_Peace()
    {
        // Peace 속성 수치 조정 부분
        Animator_Player.SetFloat("fSpeed", 2.0f);
    }

    void AttributeFunc_Forest()
    {

    }
}
