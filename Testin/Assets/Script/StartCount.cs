using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCount : MonoBehaviour
{    
    [HideInInspector]
    public bool isRun;
    private float fTime;

    void start()
    {
        isRun = false;
    }

    void Update()
    {       
        if(fTime >= 3.0f)
            isRun = true;
        else if(fTime < 3.0f)
            fTime += Time.deltaTime;
    }
}
