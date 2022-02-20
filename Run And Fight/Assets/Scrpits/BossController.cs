using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class BossController : MonoBehaviour
{
    [SerializeField]
    private Transform goal1;

    public GameObject Power;
    private NavMeshAgent playerAgent;
    public static int Powers_end = 10;
    private int Powers = 10;
    private Animator Anim;
    private bool Attack;
    // Start is called before the first frame update
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerAgent.destination = goal1.position;
        if (Attack)
        {
            Anim.SetInteger("Bot1",1);
        }
        else
        {
            Anim.SetInteger("Bot1",0);
        }

        if (Powers <= 0)
        {
            Anim.SetInteger("Bot1",2);
            Destroy(this.gameObject,2.5f);
            Instantiate(Power,new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity,transform);
            
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Attack = true;
            if (Attack)
            {
                PlayerController.Power --;
                Debug.Log(PlayerController.Power);
                
            }
            if (PlayerController.attack)
            {
                Powers--;
            
            }
            
        }
        else if(collision.collider.gameObject.CompareTag("Power"))
        {
            Destroy(collision.collider.transform.gameObject);
            Powers++;
        }
        else
        {
            Attack = false;
        }
        
    }
    

}
