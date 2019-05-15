using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private SWS.splineMove spline_move;
    private Animator Player_animator;
    private float fTime;
    private float fCol_count;

    void Start()
    {
        fCol_count = 3.0f;

        spline_move = GameObject.Find("avatar1").GetComponent<SWS.splineMove>();
        Player_animator = GameObject.Find("avatar1").GetComponent<Animator>();
    }

    void Update()
    {
        if (fTime <= 2.0f && spline_move.isCol == true)
            fTime += Time.deltaTime;
        else if(fTime >= 2.0f && spline_move.isCol == true)
        {
            spline_move.isCol = false;
            Player_animator.SetBool("isCol", false);
        }

        if(fCol_count <= 3.0f)
            fCol_count += Time.deltaTime;

        //Player_animator.SetFloat("Col_Count", fCol_count);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DangerousObj" && fCol_count >= 3.0f)
        {
            fTime = 0.0f;
            fCol_count = 0.0f;
            spline_move.isCol = true;
            Player_animator.SetBool("isCol", true);
        }
    }
}
