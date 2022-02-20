using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int n;
    public float z;
    public GameObject Power;
    public GameObject Boss;
    public float kc;
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Boss == null)
        {
            for(int i = 0; i<n; i++)
                Instantiate(Power,new Vector3(-7 + kc*i,1,z), Quaternion.identity,transform);
        }
    }
}
