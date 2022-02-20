using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Speed * Time.deltaTime;
        Destroy(this.gameObject,4);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.CompareTag("Bot"))
        {
            Destroy(other.collider.transform.gameObject);
            Destroy(this.gameObject);
        }
    }
}
