using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float spinSpeed = 90.0f;
    // Update is called once per frame
    private void Update() 
    {
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
            
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -spinSpeed * Time.deltaTime);
        }
    }
}
