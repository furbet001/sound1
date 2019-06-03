using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{

    public Text liveText;
    public static int playerLive;
    public GameObject LoseImage;
    
   



    public void Awake()
    {
        liveText = GetComponent<Text>();
        playerLive= 2;

    }


    void Update()
    {

        liveText.text = "Live: " + playerLive;

        if (playerLive == 0)
        {
            LoseImage.SetActive(true);
         
        }

        }

    void resetScore()
    {




    }


    }


