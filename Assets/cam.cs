using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject player;
    public Vector3 decalge;
    
    // Start is called before the first frame update
    void Start()
    {
        decalge = new Vector3(-0, 2, -4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + decalge;
    }
}
