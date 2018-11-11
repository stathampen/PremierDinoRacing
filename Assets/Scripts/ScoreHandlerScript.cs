using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandlerScript : MonoBehaviour {

    public int player1Score;
    public int player2Score;

	// Use this for initialization
	void Start () {
        //sop that this script persists into the main game
        DontDestroyOnLoad(gameObject);
	}

    //store the scores
    public void StoreScore(int player1Pass, int player2Pass)
    {
        player1Score = player1Pass;
        player2Score = player2Pass;
    }


    //pass the scores on to be used in the next scene
    public int GetScore1()
    {
        return player1Score;
    }
    public int GetScore2()
    {
        return player2Score;
    }
}
