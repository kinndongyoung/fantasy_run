using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndWindowTime : MonoBehaviour
{
    public Text Text_Time;
    public TimeCount Lap_Time;

    private int imin = 0;
    private int isec = 0;
    private int imsec = 0;

    void Start()
    {
        Lap_Time = GameObject.Find("LapTime").GetComponent<TimeCount>();
    }

    void Update()
    {        
        imin = Lap_Time.imin;
        isec = Lap_Time.isec;
        imsec = Lap_Time.imsec;

        Text_Time.text = string.Format("{0:d2}:{1:d2}:{2:d2}", imin, isec, imsec);
    }
}
