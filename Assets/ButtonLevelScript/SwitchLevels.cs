using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevels : MonoBehaviour
{
    /*    public SaveGame saveGame;
        public LoadGame loadGame;*/
  

    public void Levels()
    {
        SceneManager.LoadScene(5);
    }

    public void A()
    {
        SceneManager.LoadScene(1);
    }

    public void B()
    {
        SceneManager.LoadScene(2);
    }

    public void C()
    {
        SceneManager.LoadScene(3);
    }
}
