using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    public static int Power_e;
    private  int Power = 10;
    private bool Attack;
    private Animator Anim;

    public static bool Kill;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Attack)
        {
            if (Power <= 0)
            {
                Anim.SetInteger("Bot",1);
                Destroy(this.gameObject,5f);
            }
            else
            {
                Anim.SetInteger("Bot", 2);
                Kill = true;
                
                Debug.Log(PlayerController.Power);
            }
        }
        else
        {
            Anim.SetInteger("Bot",0);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.collider.gameObject.CompareTag("Player") || PlayerController.attack)
        {
            Attack = true;
            if (PlayerController.attack)
            { 
                Power--;
                Power_e = Power;
            }
        }
       
        else
        { 
            Attack = false;
        }
    }
}
