using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playAudio : MonoBehaviour
{
    public AudioSource aPlay;

    // Start is called before the first frame update
    void Start()
    {
        aPlay.GetComponent<AudioSource>(); 

    }

    void Update()
    {
        if (aPlay == null)
        {
            aPlay.Play();
            Debug.Log(aPlay); 
        }


      
    }









}
 