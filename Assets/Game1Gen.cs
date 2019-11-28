using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Gen : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 spawnLocation;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateCube()
    {
        spawnLocation = new Vector3(0, Random.value * 10, 0);
        Instantiate(enemy, spawnLocation, Quaternion.identity);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision detected");
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            CreateCube();
    }
}
