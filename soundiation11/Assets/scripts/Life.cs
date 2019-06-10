using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{

    public Text liveText;
    public static int playerLive=0;
    public GameObject LoseImage;
    
   



    public void Start()
    {
        liveText = GetComponent<Text>();
    }


    void Update()
    {

        liveText.text = "Live: " + playerLive;

        if (playerLive == -1)
        {
            LoseImage.SetActive(true);       
        }
        if (playerLive == 0)
        {
            LoseImage.SetActive(false);
        }
        }

    void LifeAdd()
    {




    }


    }


