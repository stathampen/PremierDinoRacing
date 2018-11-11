using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingProgressScript : MonoBehaviour {

    bool passedCheckpoint;
    public GameObject endUI;
    public GameObject player;

    public void PassedCheckpoint()
    {
        passedCheckpoint = true;
    }

    public void PassedFinish()
    {
        if(passedCheckpoint == true)
        {
            //end the game
            Time.timeScale = 0;
            endUI.SetActive(true);
            player.SetActive(false);
        }
    }
}
