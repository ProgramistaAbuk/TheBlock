using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class LevelCont : MonoBehaviour
{
    public int LoadLevButton = 0;
    public Button A;
    public Button B;
    public Button C;
    public string saveDirectory = "Saves";
    public string saveName = "savedGame";
    // Start is called before the first frame update

    void Start()
    {
        A.interactable = true;
        B.interactable = false;
        C.interactable = false;
        LoadFromFile();

    }
    


    // Update is called once per frame
    void LoadFromFile()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream saveFile = File.Open(saveDirectory + "/" + saveName + ".bin", FileMode.Open);

        SaveGameData loadData = (SaveGameData)formatter.Deserialize(saveFile);

        Debug.Log("LEVEL (From deserializer2)= " + loadData.level);
        
        if (loadData.level == 1)
        {
            Debug.Log("Level 1 Default");
        }

        if (loadData.level == 2)
        {
            B.interactable = true;
            C.interactable = false;
        }

        if (loadData.level == 3)
        {
            B.interactable = true;

            C.interactable = true;
        }

        if (File.Exists(saveDirectory + "/" + saveName + ".bin")) {
            Debug.Log(saveDirectory + "/" + saveName + ".bin" + "EXISTS");
        }

        if (!File.Exists(saveDirectory + "/" + saveName + ".bin")) {
            Debug.Log(saveDirectory + "/" + saveName + ".bin" + "!EXISTS");
        }

        saveFile.Close();
    }

    void Update()
    {


        if (LoadLevButton == 2)
        {
            B.interactable = true;
            C.interactable = false;
        }

        if (LoadLevButton == 3)
        {
            B.interactable = true;
            C.interactable = true;
        }

       

        /*        L1 = GameObject.Find("Button");
                L1.interactable = false;*/


        /*        A.Button.enable = false;*/
        Debug.Log("In Cont Update");
    }
}
