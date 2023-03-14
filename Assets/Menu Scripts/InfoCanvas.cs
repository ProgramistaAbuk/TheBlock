using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCanvas : MonoBehaviour
{

    public GameObject Overlay;
    public GameObject CreditsOver;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void show()
         {
        Overlay.gameObject.SetActive(false);
        Overlay.gameObject.SetActive(true);

    }

    public void hide()
    {
        animator.SetBool("run", true);

       

        /*        Overlay.gameObject.SetActive(false);*/
    }
    // Update is called once per frame
    public void endInfoExit()
    {
        animator.SetBool("run", false);
        Overlay.gameObject.SetActive(false);
    }




    void Update()
    {
        
    }
}
