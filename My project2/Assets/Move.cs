using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(9,1.5f, 0);

    void Update()
    {
        //1.MoveTowards     //매개변수(현재위치, 목표위치, 속도)
        /* transform.position = 
            Vector3.MoveTowards(transform.position, target, 1f);   */     

        //2.SmoothDamp      //매개변수(현재위치, 목표위치, 참조 속도, 속도)
        /* Vector3 velo = Vector3.zero;
    
        transform.position = 
            Vector3.SmoothDamp(transform.position, target, ref velo, 1f); */

        //3.Lerp    (선형 보간)
        /* transform.position = 
            Vector3.Lerp(transform.position, target, 0.1f); */
        
        //4.SLerp (구면 성형 보간)
        transform.position = 
            Vector3.Lerp(transform.position, target, 0.1f);
    }
}
