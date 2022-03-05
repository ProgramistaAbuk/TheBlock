using UnityEngine;
using System.Threading;

public class pausegame : MonoBehaviour
{
    public bool gamePaused = false;

    public pause pause;
    // Update is called once per frame
    void Update () { 
        if (Input.GetKey(KeyCode.Escape)) {
            //Thread.Sleep is used to pause game
            gamePaused = !gamePaused;
            // Thread.Sleep(1000);;
            
            
        }
        
        if (gamePaused) {
            pause.PauseControl();
        }

        if (!gamePaused) {
            pause.ResumeControl();
        }
        
    }


}
// public class PauseControl : MonoBehaviour
// {
//     public static bool gameIsPaused;
//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Escape))
//         {
//             gameIsPaused = !gameIsPaused;
//             pause();
//         }
//     }
//     void pause()
//     {
//         if(gameIsPaused)
//         {
//             Time.timeScale = 0f;
//         }
//         else 
//         {
//             Time.timeScale = 1;
//         }
//     }
// }
