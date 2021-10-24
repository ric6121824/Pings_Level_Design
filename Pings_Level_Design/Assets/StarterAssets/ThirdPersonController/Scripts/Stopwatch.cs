using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Stopwatch : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText;
    public TimeSpan time;

    public int tryTimes = 1;
    public List<String> roundTimes = new List<String>();

    

    void Start()
    {
        currentTime = 0;
    }

    void Update()
    {
        if(stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff") + "  LEVEL " + SceneManager.GetActiveScene().buildIndex;

        String updated_text = currentTimeText.text;
        for (int i = 0; i < roundTimes.Count; i++)
        {
            updated_text = '\n' + roundTimes[i];
        }
        currentTimeText.text = updated_text;
    }
    public void StartStopwatch()
    {
        stopwatchActive = true;
    }
    public void StopStopwatch()
    {
        stopwatchActive = false;
        
    }
    public void LapTime()
    {
        stopwatchActive = false;
        roundTimes.Add(time.ToString(@"mm\:ss\:fff") + "  LEVEL " + SceneManager.GetActiveScene().buildIndex);
        tryTimes++;
        stopwatchActive = true;
    }
}
