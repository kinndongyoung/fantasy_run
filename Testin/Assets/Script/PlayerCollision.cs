using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private SWS.splineMove spline_move;
    private Animator Player_animator;
    private float fTime;

    void Start()
    {
        spline_move = GameObject.Find("avatar1").GetComponent<SWS.splineMove>();
        Player_animator = GameObject.Find("avatar1").GetComponent<Animator>();
    }

    void Update()
    {    
        if (fTime <= 2.0f && spline_move.isCol == true)
            fTime += Time.deltaTime;
        else if(fTime > 2.0f && spline_move.isCol == true)
        {
            spline_move.isCol = false;
            Player_animator.SetBool("isCol", false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DangerousObj")
        {
            fTime = 0.0f;
            spline_move.isCol = true;
            Player_animator.SetBool("isCol", true);
        }
    }
}
