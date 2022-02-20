using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngineInternal;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float  Speed;
    public GameObject lose;
    public GameObject win;
    private Animator Anim;
    public static bool attack = false;
    private float rotation; 
    public static int Power ;
    private bool leftbutton;
    private bool rightbutton;
    private bool forwardbutton;
    private bool backbutton;
    private bool attack1;
    private bool attack2;
    private bool jumpbutton;
    private void Awake()
    {
        Anim = gameObject.GetComponent<Animator>();
      
    }

    void Start()
    {
        Power = 10;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || leftbutton)
        {
            rotation = -90;
            transform.Translate(Vector3.forward* Speed * Time.deltaTime);
            Anim.SetInteger("Player",1);
            transform.localRotation = Quaternion.Euler(0,rotation,0);
        }

        else if (Input.GetKey(KeyCode.RightArrow) || rightbutton )
        {
            rotation = 90;
            transform.Translate(Vector3.forward*Speed*Time.deltaTime);
            Anim.SetInteger("Player",1);
            transform.localRotation = Quaternion.Euler(0,rotation,0);
        }

        else if (Input.GetKey(KeyCode.DownArrow) || backbutton)
        {
            rotation = 180;
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            Anim.SetInteger("Player",1);
            transform.localRotation = Quaternion.Euler(0,rotation,0);
        }

        else if (Input.GetKey(KeyCode.UpArrow) || forwardbutton )
        {
            rotation = 0;
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            Anim.SetInteger("Player",1);
            transform.localRotation = Quaternion.Euler(0,rotation,0);
        }
        else if(Input.GetKey(KeyCode.Z) || attack1)
        {
            Anim.SetInteger("Player",2 );
            attack = true;
        }
        else if (Input.GetKey(KeyCode.X) || attack2)
        {
            Anim.SetInteger("Player",3);
            attack = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) || jumpbutton )
        {
            Anim.SetInteger("Player",4);
            jumpbutton = false;
        }
        else if ( Power<=0)
        {
           Anim.SetInteger("Player",5);
           Destroy(this.gameObject,2.5f);
           lose.SetActive(true);
        }
        else
        {
            Anim.SetInteger("Player",0);
            attack = false;
            leftbutton = false;
            rightbutton = false;
            forwardbutton = false;
            backbutton = false;
            attack1 = false;
            attack2 = false;
            jumpbutton = false;

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("DeathZone"))
        {
            lose.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.collider.gameObject.CompareTag("Win"))
        {
            win.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.collider.gameObject.CompareTag("Power"))
        {
          Destroy(collision.collider.transform.gameObject);
          Power++;
          Debug.Log(Power);
        }
        
        if (collision.collider.gameObject.CompareTag("Boss"))
        {
            if (attack)
            {
                //Power--;
                //Debug.Log(Power);
                if (BotController.Kill)
                {
                    Power--;
                    Debug.Log(Power);
                }
               
            }
            
        }
        
    }

    public void left()
    {
        leftbutton = true;
        rightbutton = false;
        forwardbutton = false;
        backbutton = false;
        attack1 = false;
        attack2 = false;
        jumpbutton = false;
    }
    public void right()
    {
        rightbutton = true;
        leftbutton = false;
        forwardbutton = false;
        backbutton = false;
        attack1 = false;
        attack2 = false;
        jumpbutton = false;
    }

    public void forward()
    {
        forwardbutton = true;
        leftbutton = false;
        rightbutton = false;
        backbutton = false;
        attack1 = false;
        attack2 = false;
        jumpbutton = false;
    }

    public void back()
    {
        backbutton = true;
        leftbutton = false;
        rightbutton = false;
        forwardbutton = false;
        attack1 = false;
        attack2 = false;
        jumpbutton = false;
    }

    public void Attack1()
    {
        attack1 = true;
        attack2 = false;
        backbutton = false;
        leftbutton = false;
        rightbutton = false;
        forwardbutton = false;
        jumpbutton = false;
    }

    public void Attack2()
    {
        attack2 = true;
        attack1 = false;
        backbutton = false;
        leftbutton = false;
        rightbutton = false;
        forwardbutton = false;
        jumpbutton = false;
    }

    public void jump()
    {
        jumpbutton = true;
        attack2 = false;
        attack1 = false;
        backbutton = false;
        leftbutton = false;
        rightbutton = false;
        forwardbutton = false;
       
    }
}
