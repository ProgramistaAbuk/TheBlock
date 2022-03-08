using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPause : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
         GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem .GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
    }
}
