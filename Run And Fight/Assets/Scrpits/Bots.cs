using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bots : MonoBehaviour
{
    public float z;
    public int n;
    public float x;
    public GameObject bot;
    public float kc;
    // Start is called before the first frame update
    
    void Start()
    {
        for (int i = 1; i < n; i++)
        {
            Instantiate(bot,new Vector3(x,1,z + kc*i), Quaternion.Euler(0,180,0),transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
