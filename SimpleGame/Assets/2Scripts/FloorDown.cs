using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDown : MonoBehaviour
{

    public float downTime;
    public float downSpeed;

    void FixedUpdate()
    {
        if(Time.time >= downTime)
        {
             //이동 로직 처리
             transform.position -= new Vector3(0, downSpeed * Time.deltaTime, 0);
        }    
    }

   /* void OnCollisionStay(Collision other)
   {
        if(other.gameObject.name == "downFloor")
        {
            transform.position -= new Vector3(0, downSpeed * Time.deltaTime, 0);
        }
   } */
}
