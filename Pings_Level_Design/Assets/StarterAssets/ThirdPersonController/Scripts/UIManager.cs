using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text txtLevel;
    Stopwatch stopWatch;

    private void Start()
    {
        
    }

    void Update()
    {
        txtLevel.text = "LEVEL " + (SceneManager.GetActiveScene().buildIndex);
    }
}
