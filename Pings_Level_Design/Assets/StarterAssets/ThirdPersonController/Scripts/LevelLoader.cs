using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using StarterAssets;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Stopwatch stopwatch;
    public GameObject player;
    public GameObject startPoint;

    private StarterAssetsInputs starterAssetsInputs;


    // Update is called once per frame
    void Start()
    {
        //stopwatch = GetComponent<>
        stopwatch.StartStopwatch();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            stopwatch.LapTime();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Reposition();
        }
        
    }
    public void Reposition()
    {

        player.transform.position = startPoint.transform.position;
    }

}
