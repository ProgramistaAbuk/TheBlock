using UnityEngine;
using UnityEngine.SceneManagement;
//For Switching Scenes ^^^

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}
