using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyUIScript : MonoBehaviour {

    public GameObject EnableToStart;

    public void Action()
    {

        Time.timeScale = 1;

        EnableToStart.SetActive(true);
        gameObject.SetActive(false);
    }

}
