using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brigde02 : MonoBehaviour
{
    public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            Instantiate(GameObject, new Vector3(15 +1.5f *i,0,56.5f), Quaternion.Euler(0,90,0),transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
