using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class LoadGame : MonoBehaviour
{
    public string saveDirectory = "Saves";
    public string saveName = "savedGame";

    public void LoadFromFile()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream saveFile = File.Open(saveDirectory + "/" + saveName + ".bin", FileMode.Open);

        SaveGameData loadData = (SaveGameData)formatter.Deserialize(saveFile);

        Debug.Log("LEVEL = " + loadData.level);

        FindObjectOfType<OnStart>().loadLevel = loadData.level;
/*        FindObjectOfType<LevelCont>().LoadLevButton = loadData.level;*/
        saveFile.Close();
    }
}
