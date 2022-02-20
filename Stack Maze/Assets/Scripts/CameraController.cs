using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private Vector3 kc;
    // Start is called before the first frame update
    void Start()
    {
        kc = target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 local = target.position - kc;
        transform.position = local;
    }
}
