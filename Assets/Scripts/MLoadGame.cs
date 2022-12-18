using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class MLoadGame : MonoBehaviour
{

    public string saveDirectory = "Saves";
    public string saveName = "savedGame";
    // Start is called before the first frame update


    public void LoadFromFileManual()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream saveFile = File.Open(saveDirectory + "/" + saveName + ".bin", FileMode.Open);

        SaveGameData loadData = (SaveGameData)formatter.Deserialize(saveFile);

        Debug.Log("LEVEL = " + loadData.level);

        if (loadData.level == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (loadData.level == 2)
        {
            SceneManager.LoadScene(2);
        }
        if (loadData.level == 3)
        {
            SceneManager.LoadScene(3);
        }
        FindObjectOfType<OnStart>().loadLevel = loadData.level;
        /*        FindObjectOfType<LevelCont>().LoadLevButton = loadData.level;*/
        saveFile.Close();
    }
}
