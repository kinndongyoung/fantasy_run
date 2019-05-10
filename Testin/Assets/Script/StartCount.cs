using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCount : MonoBehaviour
{
    public SWS.splineMove spline_move;
    private float fTime;

    void start()
    {
        spline_move.WayPointUpdate = false;
        fTime = 0.0f;
    }

    void Update()
    {       
        if(fTime >= 3.0f)
            spline_move.WayPointUpdate = true;
        else if(fTime < 3.0f)
            fTime += Time.deltaTime;
    }
}
