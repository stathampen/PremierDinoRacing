using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour {

    public barrelMovement controller;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Meat")
        {
            controller.AddScore(gameObject);
        }
    }
}
