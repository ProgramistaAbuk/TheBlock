using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SwitchLevels : MonoBehaviour
{
    /*    public SaveGame saveGame;
        public LoadGame loadGame;*/

    public OnStart onStart;


    public void Levels()
    {
        onStart.Save();
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
