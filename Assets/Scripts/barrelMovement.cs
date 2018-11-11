using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelMovement : MonoBehaviour
{

    //limits and variables
    public int leftLimit;
    public int rightLimit;
    public float speed;

    public AudioSource scource;
    public AudioClip clip;

    public int score1;
    public int score2;

    public GameObject Player1;
    public GameObject Player2;

    public barScript progressBar;

    // Update is called once per frame
    void Update()
    {
        var x1 = Input.GetAxis("Player1H") * 2 * speed;
        var x2 = Input.GetAxis("Player2H") * 2 * speed;

        Player1.transform.Translate(x1, 0, 0);
        Player2.transform.Translate(x2, 0, 0);

        //if the barrel goes to far either way
        if (Player1.transform.position.x > rightLimit)
        {
            Player1.transform.Translate(-1, 0, 0);
        }
        if (Player1.transform.position.x < leftLimit)
        {
            Player1.transform.Translate(1, 0, 0);
        }

        //if the barrel goes to far either way
        if (Player2.transform.position.x > rightLimit)
        {
            Player2.transform.Translate(-1, 0, 0);
        }
        if (Player2.transform.position.x < leftLimit)
        {
            Player2.transform.Translate(1, 0, 0);
        }
    }

    public void AddScore(GameObject player)
    {
            if (player == Player1)
                score1++;

            if (player == Player2)
                score2++;

            //slap dat meat
            scource.PlayOneShot(clip);

    }


    public int SendScore1()
    {
        return score1;
    }
    public int SendScore2()
    {
        return score2;
    }

}
