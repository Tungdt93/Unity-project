using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Camera cam;

    private Vector3 local; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        local = transform.position;
        if (Input.GetMouseButton(0))
        {
            transform.position = Input.mousePosition;
        }
        
    }
}
