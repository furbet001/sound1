using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class playVideo : MonoBehaviour
{
    public VideoPlayer vP;


    void Start()
    {
        vP = GetComponent<VideoPlayer>(); 
    }


    public void playvideo()
    {
        if (Input.GetMouseButton(2) )
        {
            vP.Play();
            Debug.Log("clicked");
        }
        
    }
}
