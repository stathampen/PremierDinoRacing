using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoCollisionDetect : MonoBehaviour {

    public SimpleMovement controller;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Meat")
        {
            //get rid of the meat
            collision.gameObject.SetActive(false);
            controller.SpeedBoost(gameObject);
        }
    }
}
