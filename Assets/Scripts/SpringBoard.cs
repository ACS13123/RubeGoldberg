using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBoard : MonoBehaviour {
    float BounceValue = 20;
    public Rigidbody player;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.tag == "Spring")
            {
            player.velocity = new Vector3(0, BounceValue, 0);
            }   
        }

}
