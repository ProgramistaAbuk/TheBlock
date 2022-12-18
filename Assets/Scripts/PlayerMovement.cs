using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;


    public float forwardForce = 4000f;
    public float sidewaysForce = 25f;
    public float upwardsForce = 800f;
    public float landForce = 400000f;
    public float mass;
/*    public SaveGame saveGame;*/

    public bool touch_ground = true;
    /*    public LoadGame loadGame;*/
    public OnStart onStart;




    //use rb = GetComponent<RigidBody>();
    //and rb.mass = mass
    //then you can set the amount of mass using
    //rb.mass = 10f

    // Update is called once per frame
    void Start()
    {

        /*  loadGame.LoadFromFile();*/
        onStart.OnStarts();
        touch_ground = true;
    }
    void Update()
    {
        
    }
    void FixedUpdate()
    {


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        

        if (Input.GetKey("d"))
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*Jump*/
        if (Input.GetKey("space") && touch_ground == true)
        {

            jump();
            Debug.Log("Space Bar pressed");

        }
        if (touch_ground == false)
        {
            Debug.Log("Already in air");
        }

        //Saving
/*
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level01"))
        {
            *//*saveGame.SaveToFile();*//*
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level02"))
        {
            saveGame.SaveToFile();
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level03"))
        {
            saveGame.SaveToFile();
        }*/
        //Saving
        void jump()
        {
            Debug.Log("Jump activated!");

            Debug.LogWarning("Przed rb.position.y = " + rb.position.y);
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            sidewaysForce = 0f;
            forwardForce = 2000f;
            //Display y position and upwards force
            Debug.Log("Po rb.position.y = " + rb.position.y);
            Debug.Log("UpwardsForce = " + upwardsForce);
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            touch_ground = false;

        }
    }

}


