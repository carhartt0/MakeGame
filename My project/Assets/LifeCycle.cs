using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //Awake 함수는 프로그램이 시작될 때 딱 한번만 실행됨
    private void Awake() 
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    //Start : 업데이트 시작 직전, 최초 실행되는 함수
    void private void Start() 
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    //---------------Awake, Start 는 초기화 함수

    //FixedUpdate : 물리 연산 업데이트 - 고정된 실행 주기로 CPU를 많이 사용, 부하가 많다
    void private void FixedUpdate() 
    {
        Debug.Log("이동~~!");
    }
}
