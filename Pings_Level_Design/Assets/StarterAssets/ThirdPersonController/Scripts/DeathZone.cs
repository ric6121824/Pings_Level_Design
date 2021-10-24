using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{

    public Stopwatch stopWatch;
    public LevelLoader levelLoader;

    // Start is called before the first frame update
    //void Start()
    //{
    //    levelLoader = GetComponent<LevelLoader>();
    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //stopWatch.LapTime();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            levelLoader.Reposition();
            Debug.Log("You're dead!");
        }
        else if(other.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }
}
