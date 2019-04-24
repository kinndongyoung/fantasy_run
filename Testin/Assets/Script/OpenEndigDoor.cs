using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEndigDoor : MonoBehaviour
{
    public float MovePosY = 0.0f;
    private int count = 0;

    bool isOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpen) Open();
    }

    void Open()
    {
        isOpen = true;
        count++;

        Vector3 Pos = transform.localPosition;
        Pos.y += MovePosY;

        transform.localPosition = Pos;

        if (count < 90)
            Invoke("Open", Time.deltaTime);
        else
        {
            count = 0;
            isOpen = false;
        }            
    }
}
