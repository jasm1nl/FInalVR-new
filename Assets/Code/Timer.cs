using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;

    public float secondsLeft = 30;
    // public bool takingAway = false;

    void Update()
    {
        if (secondsLeft > 0)
        {
            secondsLeft -= Time.deltaTime;
        }
        else
        {
            secondsLeft = 0;
            //can do something like this (secondsLeft+=90;)
            //we can also add scene switch, which would probably be the lose scene
        }
        DisplayTime(secondsLeft);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
