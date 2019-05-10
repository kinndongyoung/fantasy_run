using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject EndWindow;
    public GameObject Player;
    public TimeCount LapTime;
    
    private Animator Player_animator;
    
    private float fTime;

    void Start()
    {
        EndWindow = GameObject.Find("EndWindow");
        LapTime = GameObject.Find("LapTime").GetComponent<TimeCount>();
        Player_animator = Player.GetComponent<Animator>();

        EndWindow.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player_animator.SetBool("EndMotion", true);
            LapTime.Time_bState = false;
        }            
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fTime += Time.deltaTime;

            if(fTime >= 1.5f)
            {
                EndWindow.SetActive(true);
            }
        }
    }
}
