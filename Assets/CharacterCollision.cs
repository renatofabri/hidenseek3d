using UnityEngine;

public class CharacterCollision : MonoBehaviour {

    public CharacterController movement;

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Landing");
        if (collision.collider.tag == "obstacle") {
            // movement.enabled = false;
        }
        if (collision.collider.tag == "ground") {
            movement.canJump = true;
        }
    }

    void OnCollisionExit(Collision collision) {
        Debug.Log("Leaving ground!");
        if (collision.collider.tag == "ground") {
            movement.canJump = false;
        }
    }
}
