using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight2 : MonoBehaviour
{
    public GameObject Boss2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.collider.gameObject.CompareTag("Player"))
        {
            Boss2.SetActive(true);
        }
    }
}
