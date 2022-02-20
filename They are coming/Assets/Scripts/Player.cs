using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject GameObject;

    public float maxTime;
    public float Speed;
    private float time;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Speed * Time.deltaTime);
        
        if (time > maxTime)
        {
            Instantiate(GameObject, transform.position,
                Quaternion.identity, transform);
            time = 0;
        }

        time += Time.deltaTime;
    }

}
