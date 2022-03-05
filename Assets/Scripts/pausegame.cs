using UnityEngine;
using System.Threading;

public class pausegame : MonoBehaviour
{
    public bool gamePaused = false;

    public pause pause;
    // Update is called once per frame
    void Update () { 
        if (Input.GetKeyUp(KeyCode.Escape)) {
            //Thread.Sleep is used to pause game
            // Thread.Sleep(1000);
            gamePaused = !gamePaused;
        }
        
        if (gamePaused) {
            pause.PauseControl();
        } else {
            pause.ResumeControl();
        }
    }
}
