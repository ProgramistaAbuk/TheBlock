using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OnStartMenu : MonoBehaviour
{
    public GameObject Overlay;
    public GameObject CreditsOver;

    // Start is called before the first frame update
    void Start()
    {
        Overlay.gameObject.SetActive(false);
        CreditsOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
