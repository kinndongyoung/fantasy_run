using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float fJumpPower = 0.0f;
    Rigidbody Player_rigidbody;
    Animator Player_animator;
    bool isJumping;

    void Start()
    {
        Player_rigidbody = GetComponent<Rigidbody>();
        Player_animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;

            Player_rigidbody.AddForce(Vector3.up * fJumpPower, ForceMode.Impulse);
            Player_animator.SetBool("isJumping", true);
        }
        else if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            Player_animator.SetBool("isJumping", false);
        }
    }
}
