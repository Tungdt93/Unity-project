using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBS : MonoBehaviour
{
    public int n;

    public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < n; i++)
        {
            Instantiate(GameObject, new Vector3(-4f + 2.6f*i,1f,-4f), Quaternion.identity,transform);
            
        }

        for (int i = 0; i < n+1; i++)
        {
            Instantiate(GameObject, new Vector3(3.7f,0.5f,6.5f - 2.1f*i), Quaternion.identity, transform);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
