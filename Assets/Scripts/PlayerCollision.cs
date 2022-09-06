using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("Hit obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }

        if (collisionInfo.collider.tag == "Ground")
        {
            movement.touch_ground = true;
            movement.sidewaysForce = 25f;
            movement.forwardForce = 3000f;
            Debug.Log("Touching Ground");

        }
    }

}
