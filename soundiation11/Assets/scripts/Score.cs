using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{

    public Text scoreText;
    private int score=0;
    public GameObject canvas;

    void Start()
    {
        scoreText = GetComponent<Text>();
        
    }

    
    void Update()
    {
      if(canvas.GetComponent<countdownTime>().currentTime == score)
        {

        }
        



    }
}
