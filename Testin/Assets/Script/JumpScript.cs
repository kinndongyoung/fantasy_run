using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    enum STATE
    {
        eIDLE   ,
        eUP     ,
        eDOWN   ,
    }

    private float fTime = 0.0f;
    private Vector3 Temp_PlayerPos;
    public float fJumpPower = 0.0f;
    public GameObject Player;
    Rigidbody Player_rigidbody;
    CapsuleCollider Player_Collider;
    Animator Player_animator;
    bool isJumping;
    int bCheck;

    void Start()
    {
        bCheck = (int)STATE.eIDLE;

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
            bCheck = (int)STATE.eUP;
            Player_rigidbody.AddForce(Vector3.up * fJumpPower, ForceMode.Impulse);
            Player_animator.SetBool("isJumping", true);

            Temp_PlayerPos = Player.transform.localPosition;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            Player_animator.SetBool("isJumping", false);
        }

        //콜리더 박스가 올라갔다 내려갔다.
        Player_Collider.center = new Vector3(0, 1.3f, 0);

        switch (bCheck)
        {
            case (int)STATE.eIDLE:
            {
                Player_Collider.center = new Vector3(0, 1.3f, 0);
            }
            break;
            case (int)STATE.eUP:
            {
                Player_Collider.center = new Vector3(0, (fJumpPower * Time.deltaTime), 0);
                fTime += Time.deltaTime;

                if (Player.transform.localPosition.y >= Temp_PlayerPos.y + 10)
                {
                    bCheck = (int)STATE.eDOWN;
                    fTime = 0.0f;
                }
            }
            break;
            case (int)STATE.eDOWN:
            {
                Player_Collider.center = new Vector3(0, ((-fJumpPower) * Time.deltaTime), 0);
                fTime += Time.deltaTime;

                if (Player.transform.localPosition.y <= Temp_PlayerPos.y)
                {
                    bCheck = (int)STATE.eIDLE;
                    Player.transform.localPosition.Set(Temp_PlayerPos.x, Temp_PlayerPos.y, Temp_PlayerPos.z);
                    fTime = 0.0f;
                }                        
            }
            break;
        }
    }
}
