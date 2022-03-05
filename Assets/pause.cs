using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class pause : MonoBehaviour
{

    public GameObject pauseUI;

    [Range(1.0f, 10.0f)]
    public float restartDelay;

    public void PauseControl() {
        // pauseUI.SetActive(false);
        pauseUI.SetActive(true);
        // Time.timeScale = 0f;
        // Thread.Sleep(1000); Something like this but just pauses this program not others
        // AnimatePause();
        }
        
    public void ResumeControl() { 
        // Time.timeScale = 1f;
        // Thread.Sleep(1000); Something like this but just pauses this program not others
        // AnimateResume();
        pauseUI.SetActive(false);
    }
    

}