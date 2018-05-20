using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform Destination;

    private void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Teleporter")
        {
            transform.position = Destination.transform.position + new Vector3(0,-2,0);
        }
    }
}
