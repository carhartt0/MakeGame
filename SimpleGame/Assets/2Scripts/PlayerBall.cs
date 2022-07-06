using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public GameManager manager;
    bool isJump;
    Rigidbody rigid;
    AudioSource audio;

    void Awake() 
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update() 
    {
        if(Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }    
    }
    void FixedUpdate() 
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Floor")
            isJump = false;    
    }
    
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Item")
        {
            
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }    
        else if(other.tag == "Finish")
        {
            if(itemCount == manager.totalItemCount)
            {
                //Game clear! && Next Stage
                if(manager.stage == 4)
                    SceneManager.LoadScene(0);
                else
                //SceneManager.LoadScene("Example1_"+(manager.stage+1).ToString());  --> 아랫줄로 간단하게 바꿈
                    SceneManager.LoadScene(manager.stage + 1);

            }
            else
            {
                //Restart!
                SceneManager.LoadScene(manager.stage);
            }
        }
        
    }

}
