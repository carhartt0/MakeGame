using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public float startTime;
    public float minZ, maxZ;

    [Range(1,100)]
    public float moveSpeed;
    private int sign = -1;
    

    
    void FixedUpdate()
    {
        if(Time.time >= startTime)
        {
             //이동 로직 처리
             transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime * sign);

             if(transform.position.z <= minZ || transform.position.z >= maxZ)
             {
                sign *= -1;
             }
        }    
    }
}
