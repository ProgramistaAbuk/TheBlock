using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelCont : MonoBehaviour
{
    public int LoadLevButton = 0;
    public Button A;
    public Button B;
    public Button C;
    // Start is called before the first frame update

    void Start()
    {
        A.interactable = true;
        B.interactable = false;
        C.interactable = false;

    }


    // Update is called once per frame
    void Update()
    {


        if (LoadLevButton == 2)
        {
            B.interactable = true;
        }

        else if (LoadLevButton == 3)
        {
            C.interactable = true;
        }

        /*        L1 = GameObject.Find("Button");
                L1.interactable = false;*/


        /*        A.Button.enable = false;*/
        Debug.Log("In Cont Update");
    }
}
