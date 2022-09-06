using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class OnStart : MonoBehaviour
{
    public int level = 1;
    public SaveGame saveGame;
    public LoadGame loadGame;
/*    public SaveGameData saveGameData;*/
    public int loadLevel = 1;
    public string directoryExist = "Saves";
    public string fileName = "savedGame.bin";
    /*    public string filePath = "c:/Projects/TheBlock" + Application.temporaryCachePath + "/" + "Saves" + "/" + fileName;*/
    public string filePath = "c:/Users/jakob/Documents/App/Unity/Projects/TheBlock/Saves/savedGame.bin";
    public string folderPath = "c:/Users/jakob/Documents/App/Unity/Projects/TheBlock/Saves/";
    public PlayerLoad pLoad;
    // Start is called before the first frame update
    /*
         foreach(ClassType item in classArray)
     {
          //item.functions(arguments);
          //item.variables = values;

     }*/
    public void OnStarts()
    {
        /*return null */
    }
        void Start()
        {

/*        System.Diagnostics.Process process = new System.Diagnostics.Process();
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
        process.StartInfo.FileName = "C:/Users/jakob/PycharmProjects/UnityLenght/main.py";
        process.StartInfo.Arguments = "ARGUMENT";
        process.Start();
        process.WaitForExit();
*/



        Debug.Log("In Start");
        SceneManager.sceneLoaded += OnSceneLoaded;
        /*loadGame.LoadFromFile();*/
        /*        if (Directory.Exists(directoryExist))
                {
                    Directory.CreateDirectory(directoryExist);
                }*/
        /*  if (System.IO.Directory.Exists(filePath))
          {*/
        if (File.Exists(filePath))
        {
            loadGame.LoadFromFile();
            Debug.Log(filePath + " " + "Exists");
        }


        
/*        if (!System.IO.File.Exists(filePath))
        {
            Debug.Log(filePath + " " + "Does not exist");
            saveGame.SaveToFile();
            *//*loadGame.LoadFromFile();*//*
            Debug.Log(filePath + " " + "Exists After recreation");

        }*/
            /*PlayerPrefs.GetInt("level");*/
            /*level = PlayerPrefs.GetInt("level");*/
            if (loadLevel == 2)
            {
                SceneManager.LoadScene("Level02");
            }
            if (loadLevel == 3)
            {
                SceneManager.LoadScene("Level03");
            }
        }
    public void Save()
    {
        saveGame.SaveToFile();
        /*PlayerPrefs.SetInt("level", level);*/
    }
    // Update is called once per frame
    /*        void Update()
            {*/
    private void OnSceneLoaded(Scene aScene, LoadSceneMode aMode)
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level01"))
        {
            /*saveGameData.level = 1;*/
            /*saveGame.SaveToFile();*/
            Save();
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level02"))
        {
            /*saveGameData.level = 2;*/
            Save();
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level03"))
        {
            /*saveGameData.level = 3;*/
            Save();
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level01"))
        {
            saveGame.saveGameData.level = 1;
            /*saveGameData.level = 1;*/
            /*saveGame.SaveToFile();*/
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level02"))
        {
            saveGame.saveGameData.level = 2;
            /*saveGameData.level = 2;*/
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level03"))
        {
            saveGame.saveGameData.level = 3;
            /*saveGameData.level = 3;*/
        }
    }

/*        }*/
    
}
