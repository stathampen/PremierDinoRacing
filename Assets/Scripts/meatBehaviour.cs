using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatBehaviour : MonoBehaviour {

    public int maxSpeed = 10;
    public int minSpeed = 5;
    public int minXPos;
    public int maxXPos;
    public int yPos = 30;

    int speed;
    int xPos;

    private void Start()
    {           //removes ambiguaty
        speed = UnityEngine.Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(0, -speed * Time.deltaTime, 0);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("hit Barrel");
            Respawn();
        }
        else
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        Vector3 startPos = new Vector3(UnityEngine.Random.Range(minXPos, maxXPos), yPos, 8.5f);
        transform.position = startPos;
    }
}
