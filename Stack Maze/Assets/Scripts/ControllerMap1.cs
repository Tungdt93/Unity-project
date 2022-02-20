using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMap1 : MonoBehaviour
{
    public GameObject Goal;

    public GameObject Bridge;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal == null)
        {
            Bridge.SetActive(true);
        } 
    }
}
