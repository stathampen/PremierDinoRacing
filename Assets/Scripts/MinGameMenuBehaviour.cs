using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MinGameMenuBehaviour : MonoBehaviour {

    //the differentUI and objects
    public GameObject enableToStart;
    public GameObject endUI;
    public Text endText;

    public ScoreHandlerScript scoreHolder;
    public barrelMovement controller;

    public void Finish()
    {
        endUI.SetActive(true);
        enableToStart.SetActive(false);
        EndText();
    }

    public void ToGame()
    {

        //grab hold of the scores and store them
        scoreHolder.StoreScore(
            controller.score1,
            controller.score2);

        Time.timeScale = 1;

        //go to the main game
        SceneManager.LoadScene(2);

    }

    void EndText()
    {
        string text = "Player1 speed will be: " + controller.score1.ToString() + ", and Player2 speed will be: " + controller.score2.ToString();
        endText.text = text;
    }

}
