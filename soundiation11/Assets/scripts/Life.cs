﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{

    public Text liveText;
    public static int playerLive = 2;
    public GameObject LoseImage;
     
    int playerIdle = 0;



    public void Awake()
    {
        liveText = GetComponent<Text>();



    }


    void Update()
    {

        liveText.text = "Live: " + playerLive;

        if (playerLive == 0)
        {
            LoseImage.SetActive(true);
           // playerIdle = playerLive;

        }

        }
    }

