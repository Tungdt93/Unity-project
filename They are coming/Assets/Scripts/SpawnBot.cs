using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnBot : MonoBehaviour
{
    public GameObject GameObject;

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject h1, h2, h3;
        
        for (int i = 0; i < 10; i++)
        {
             h1 = Instantiate(GameObject, new Vector3(-4, 3, 100 + 1 * i), Quaternion.identity, transform);
             h2 = Instantiate(GameObject, new Vector3(0, 3, 100 + 1 * i), Quaternion.identity, transform);
             h3 = Instantiate(GameObject, new Vector3(4, 3, 100 + 1 * i), Quaternion.identity, transform);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
