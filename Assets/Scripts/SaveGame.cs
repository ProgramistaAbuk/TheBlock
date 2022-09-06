using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveGame : MonoBehaviour
{
    public string saveName = "savedGame";
    public string directoryName = "Saves";
    public SaveGameData saveGameData;
    public OnStart onStart;

    /*saveGameData = onStart.level;*/
    // Update is called once per frame

    public void SaveToFile()
        {
            if (!Directory.Exists(directoryName)) {
                Directory.CreateDirectory(directoryName);
            }

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream saveFile = File.Create(directoryName + "/" + saveName + ".bin");

            formatter.Serialize(saveFile, saveGameData);

            saveFile.Close();

            Debug.Log("Game Saved to " + Directory.GetCurrentDirectory().ToString() + "/Saves/" + saveName + ".bin");
        }
    
}
