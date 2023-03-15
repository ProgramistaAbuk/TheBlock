using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCanvas : MonoBehaviour
{

    public GameObject Overlay;
    public Animator animator;

    public GameObject CreditsOver;
    public Animator animatorC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void show()
         {

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
    // Credits
    public void showCredits()
    {
        CreditsOver.gameObject.SetActive(true);
    }

    public void hideCredits()
    {
        animatorC.SetBool("run", true);
        CreditsOver.gameObject.SetActive(false);
    }

    public void endCreditsExit()
    {
        animatorC.SetBool("run", false);
        CreditsOver.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
