using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BButtonLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
        /*        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetDisabledGameObject(true);*/
        /*        Level01.enabled = false;*/
    }
}
