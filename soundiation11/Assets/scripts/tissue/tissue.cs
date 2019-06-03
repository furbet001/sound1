using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class tissue : MonoBehaviour
{
    public GameObject cameraM;
    public int index;
    public GameObject winImage;
    private bool WinSceneActivate;


    public void ButtonPress(string index)
    {
        if (cameraM.GetComponent<gameManager>().randomSound == int.Parse(index))
        {
            WinSceneActivate = !WinSceneActivate;
            winImage.SetActive(WinSceneActivate);
            Debug.Log("correct");
        }
         
            
        else 
        {
            Life.playerLive--; 
            
       
            Debug.Log("Incorrect");
        }


    }
}
