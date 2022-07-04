using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMove : MonoBehaviour
{
    void Start()
    {
        /* Vector3 vec = new Vector3(5, 0, 0);     //크기 방향 모두 가진값 : 벡터 값,,, 크기만 가진 값 : 스칼라 값
        //Translate : 벡터 값을 현재 위치에 더하는 함수
        transform.Translate(vec); */

    }

    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0);
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);

        //Input : 게임 내 입력을 관리하는 클래스, anyKeyDown : 아무 입력을 최초로 받을 때 true
        //if(Input.anyKeyDown)
        //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        
        //if(Input.anyKey)
        //    Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        //각 입력 함수는 3가지 행동으로 구분 - Down(누를 때) Stay(누르고 있을 때) Up(눌렀다 땔 때)
        
        /* if(Input.GetKeyDown(KeyCode.Return))        //Enter키 -> Return , Esc키 -> Escape
            Debug.Log("아이템을 구입하였습니다.");
        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");
        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다."); */

        /* if(Input.GetMouseButtonDown(1))         //0 -> 마우스 왼쪽 , 1-> 마우스 오른쪽
            Debug.Log("미사일 발사!");
        if(Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        if(Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!"); */

        //if(Input.GetButtonDown("Superfire"))
        //    Debug.Log("필살기!");
        //if(Input.GetButton("Jump"))
        //    Debug.Log("점프 모으는중...");
        //if(Input.GetButtonUp("Jump"))
        //    Debug.Log("슈퍼 점프!");    

        if(Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..."
                +Input.GetAxisRaw("Horizontal"));
        }
        
        if(Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..."
                +Input.GetAxisRaw("Vertical"));
        }
    }
}
