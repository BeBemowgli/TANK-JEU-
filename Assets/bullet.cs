using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float launchSpeed = 25.0f;

    public GameObject objectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SpawnObject();
        }
        
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void SpawnObject()
    {
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRotation = quaternion.identity;

        Vector3 localXDirection = transform.TransformDirection(Vector3.forward);
        Vector3 velocity = localXDirection * launchSpeed;
        // Instantiate Object
        GameObject newObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);

        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.velocity = velocity;
    }
}
