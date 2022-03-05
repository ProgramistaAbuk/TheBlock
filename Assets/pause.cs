using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class pause : MonoBehaviour
{

    public GameObject pauseUI;

//how to make a slider:
    // [Range(1.0f, 10.0f)]
    // public float restartDelay;

    public void PauseControl() {

        pauseUI.SetActive(true);


            

        }
        
    public void ResumeControl() { 
        pauseUI.SetActive(false);
            Time.timeScale = 1f;


        
    }
    
    public void AnimationPause() {
            Time.timeScale = 0f;
    }

    
}