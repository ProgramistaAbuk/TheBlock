using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardsForce = 30f;
    public float mass;


//use rb = GetComponent<RigidBody>();
//and rb.mass = mass
//then you can set the amount of mass using
//rb.mass = 10f

    // Update is called once per frame
    void FixedUpdate ()
    {
     rb.AddForce(0, 0, forwardForce * Time.deltaTime);   

    if (Input.GetKey("d") ) {
        
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (Input.GetKey("a") )
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (Input.GetKey("space") ) {
       jump();
    }

    void jump() {
    if (rb.position.y <= 1.2f) {
                
        rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
        rb.mass = 1f;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
    }


void land() {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
        rb.mass = 1f;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        }

    

    if (Input.GetKeyUp("space") )
    {
        landAir();
    }

    void landAir () {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
        rb.mass = 400000f;
        rb.AddForce(0, 0, 4000000 * Time.deltaTime);
        land();
    }

   
    
    if (rb.position.y < -1f) {
        FindObjectOfType<GameManager>().EndGame();
    }

    }
    }

