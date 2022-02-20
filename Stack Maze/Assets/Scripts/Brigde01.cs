using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brigde01 : MonoBehaviour
{
    public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            Instantiate(GameObject, new Vector3(3.7f,0,34.7f+1.5f*i), Quaternion.identity,transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
