using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBS2 : MonoBehaviour
{
    public int n;

    public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < n; i++)
        {
            Instantiate(GameObject, new Vector3(3.7f,1f,21.25f), Quaternion.identity,transform);
            
        }

        for (int i = 0; i < 4; i++)
        {
            Instantiate(GameObject, new Vector3(4 - 2.6f*i,1f,23.5f), Quaternion.identity,transform);
        }

        for (int i = 0; i < 3; i++)
        {
            Instantiate(GameObject, new Vector3(-4,1f,30.25f- 2.25f*i), Quaternion.identity,transform);
        }

        for (int i = 0; i < 3; i++)
        {
            Instantiate(GameObject, new Vector3(-1.25f + 2.6f*i,1f,30.25f), Quaternion.identity,transform);
        }
        for (int i = 0; i < 1; i++)
        {
            Instantiate(GameObject, new Vector3(3.55f,1f,32.5f), Quaternion.identity,transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
