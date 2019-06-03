using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdownTime : MonoBehaviour
{
    public float currentTime= 0f;
    public float actualTime= 25f;

    
    public Text countdownText;



    void Start()
    {
        currentTime = actualTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(0);

        }
        }
    
}
