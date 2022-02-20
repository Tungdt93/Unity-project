using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBS3 : MonoBehaviour
{
    public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(GameObject, new Vector3(4, 1f, 48 + 2.2f * i), Quaternion.identity, transform);
            
        }

        for (int i = 0; i < 3; i++)
        {
            Instantiate(GameObject, new Vector3(7 + 2.7f * i,1f,48), Quaternion.identity, transform);
        }

        for (int i = 0; i < 4; i++)
        {
            Instantiate(GameObject, new Vector3(12.5f,1f,57 - 2.2f *i), Quaternion.identity, transform);
        }

        for (int i = 0; i < 2; i++)
        {
            Instantiate(GameObject, new Vector3(7 + 2.7f *i,1f,57), Quaternion.identity, transform);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
