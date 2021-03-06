using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
           
    }

    // RigidBody 관련 코드는 FixedUpdate에 작성
    void FixedUpdate()
    {
        //rigid.velocity = Vector3.forward; //#1. 속력 바꾸기 

        //#2. 힘을 가하기
         if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

       rigid.AddForce(vec, ForceMode.Impulse);

       //#3. 회전력
       //rigid.AddTorque(Vector3.back);

    }
    private void OnTriggerStay(Collider other) 
    {
        if(other.name == "Cube")
            rigid.AddForce(Vector3.up *2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up *2, ForceMode.Impulse);
    }
}
