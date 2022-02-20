using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    // Start is called before the first frame update
    public int n;
    public float z;
    public GameObject Power;
    public float kc;
    void Start()
    {
        for (int i = 1; i < n; i++)
        {
            Instantiate(Power,new Vector3(-7 + kc*i,1,z), Quaternion.identity,transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
