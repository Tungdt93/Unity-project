using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brigde : MonoBehaviour
{
    public GameObject GameObject;
    
    private GameObject gb;
    // Start is called before the first frame update
    

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Instantiate(GameObject, new Vector3(3.7f,0,8+1.5f*i), Quaternion.identity,transform);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
