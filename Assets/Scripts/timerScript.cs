using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerScript : MonoBehaviour {

    public MinGameMenuBehaviour menuSystem;


	// Use this for initialization
	void Start () {
        StartCoroutine(StartCountdown());
	}

    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }

        Time.timeScale = 0;
        Debug.Log("Timer Ended");

        menuSystem.Finish();
    }
}
