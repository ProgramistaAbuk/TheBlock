using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float sidewaysForce = 2000f;


    // Update is called once per frame
    void FixedUpdate ()
    {
    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
    }
}
