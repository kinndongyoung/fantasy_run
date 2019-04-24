using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    public float rotAngle = 0;
    private int count = 0;

    //기본적으로 문이 닫혀있다 판정
    bool isOpen = false;

    //콜라이더의 "isTrigger" 활성화 상태시 OncollisonEnter를 대신해 발동.
    void OnTriggerEnter(Collider other) 
    {
        //플레이어가 영역내에 접근했고, 현재 문이 닫힌경우 문을 연다.
        if (other.gameObject.tag == "Player" && !isOpen) Open(); 
    }
    void Open()
    {
        //문이 90도 열린상태에서 더 회전하는걸 막기위해 문이 열렸다고 판정짓는다.
        isOpen = true;
        //횟수 증가
        count++;
        //현재 회전값을 받는다.
        Vector3 rot = transform.eulerAngles;
        //y축쪽으로 1도 회전
        rot.y += rotAngle;
        //현재 회전값을 변경한 회전값으로
        transform.eulerAngles = rot;
        //90도 미만 회전시 일정시간 딜레이후 다시 함수 실행
        if (count < 90)
            Invoke("Open", Time.deltaTime); 
        else //90도 회전시
        {
            //추후 다시 문을 닫을경우를 대비해 카운트 초기화
            count = 0;
            isOpen = false;
        }
    }
}