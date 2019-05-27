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

    public GameObject AttributeObj_Space;
    public GameObject AttributeObj_Fire;
    public GameObject AttributeObj_Peace;
    public GameObject AttributeObj_Forest;

    private int Rand_Attribute;

    void Awake()
    {
        AttributeObj_Space = GameObject.Find("Attribute_Space");
        AttributeObj_Fire = GameObject.Find("Attribute_Fire");
        AttributeObj_Peace = GameObject.Find("Attribute_Peace");
        AttributeObj_Forest = GameObject.Find("Attribute_Forest");

        AttributeObj_Space.SetActive(false);
        AttributeObj_Fire.SetActive(false);
        AttributeObj_Peace.SetActive(false);
        AttributeObj_Forest.SetActive(false);
    }

    void Start()
    {
        Rand_Attribute = Random.Range(1, 5);

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

    }

    void AttributeFunc_Peace()
    {

    }

    void AttributeFunc_Forest()
    {

    }
}
