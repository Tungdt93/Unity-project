using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
    
    private Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        Offset = Target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 location = Target.position - Offset;
        transform.position = location;
    }
}
