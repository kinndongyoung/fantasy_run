using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    private float fTime = 0.0f;
    private bool bCheck = false;
    public float fJumpPower = 0.0f;
    Rigidbody Player_rigidbody;
    CapsuleCollider Player_Collider;
    Animator Player_animator;
    bool isJumping;

    void Start()
    {
        Player_Collider = GetComponent<CapsuleCollider>();
        Player_rigidbody = GetComponent<Rigidbody>();
        Player_animator = GetComponent<Animator>();
    }
    //505 -247 0
    //0.8 0.8 1
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {

            isJumping = true;
            bCheck = true;
            Player_rigidbody.AddForce(Vector3.up * fJumpPower, ForceMode.Impulse);
            Player_animator.SetBool("isJumping", true);
        }
        else if (Input.GetButtonUp("Jump"))
        {

            isJumping = false;

            Player_animator.SetBool("isJumping", false);

        }
        //콜리더 박스가 올라갔다 내려갔다.
        if (bCheck == true)
        {
            Player_Collider.center = new Vector3(0, (fTime + 1.3f), 0);
            fTime += Time.deltaTime;

        }
        if (fTime >= 1.3f)
        {
            Player_Collider.center = new Vector3(0, (float)1.3, 0);
            bCheck = false;
            fTime = 0.0f;
        }
    }
}
