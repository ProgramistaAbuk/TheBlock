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
    public string saveName = "savedGame";
    public string directoryName = "Saves";
    public SaveGameData saveGameData;
    public OnStart onStart;


    public void Levels()
    {
        if (!Directory.Exists(directoryName))
        {
            Directory.CreateDirectory(directoryName);
        }

        BinaryFormatter formatter = new BinaryFormatter();

        FileStream saveFile = File.Create(directoryName + "/" + saveName + ".bin");

        formatter.Serialize(saveFile, saveGameData);

        saveFile.Close();

        Debug.Log("From SwitchLevels Game Saved to " + Directory.GetCurrentDirectory().ToString() + "/Saves/" + saveName + ".bin");
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
