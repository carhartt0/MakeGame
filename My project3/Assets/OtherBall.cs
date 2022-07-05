using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }
    //CollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.name == "My Ball")
            mat.color = new Color(0,0,0);
    }
     //물리적 충돌중일 때 호출되는 함수
    /* private void OnCollisionStay(Collision other)
    {
        
    } */
    //물리적 충돌이 끝났을 때 호출되는 함수
    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.name == "My Ball")
            mat.color = new Color(1,1,1);
    } 
}
