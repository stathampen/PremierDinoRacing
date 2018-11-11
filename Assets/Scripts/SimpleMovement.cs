using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour {

    public AudioSource scource;
    public AudioClip clip;

    //the speed holder which will help decide the t-rex's speed
    public ScoreHandlerScript passedscore;

    //the dinosaurs
    public GameObject Player1;  //the green one
    public GameObject Player2; //the pink one


    public float moveSpeed1;
    public float moveSpeed2;
    public float turnSpeed;

    int multiplier = 5;

    private void Start()
    {
        try
        {
            passedscore = GameObject.FindObjectOfType<ScoreHandlerScript>();
        }
        catch
        {
            passedscore = GameObject.FindObjectOfType<ScoreHandlerScript>();
        }

        moveSpeed1 = (float)multiplier * (float)(passedscore.player1Score * 0.5);
        moveSpeed2 = (float)multiplier * (float)(passedscore.player2Score * 0.5);


        //if the user gets nothing they can at least move forward.
        if(moveSpeed1 == 0)
        {
            moveSpeed1 = 10f;
        }
        if (moveSpeed2 == 0)
        {
            moveSpeed2 = 10f;
        }
    }


    void Update()
    {
        var x1 = Input.GetAxis("Player1H") * Time.deltaTime * turnSpeed;
        var z1 = -Input.GetAxis("Player1V") * Time.deltaTime * moveSpeed1;

        Player1.transform.Rotate(0, x1, 0);
        Player1.transform.Translate(0, 0, z1);

        var x2 = Input.GetAxis("Player2H") * Time.deltaTime * turnSpeed;
        var z2 = -Input.GetAxis("Player2V") * Time.deltaTime * moveSpeed2;

        Player2.transform.Rotate(0, x2, 0);
        Player2.transform.Translate(0, 0, z2);
    }

    //increase the speed of the player
    public void SpeedBoost(GameObject player)
    {
        //make noise of speedboost
        scource.PlayOneShot(clip);


        if(player == Player1)
        {
            moveSpeed1 += 5f;
        } else
        {
            moveSpeed2 += 5f;
        }
    }
}

