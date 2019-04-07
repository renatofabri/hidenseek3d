using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpStrength = 100000f;
    public bool canJump = false;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("w")) {
            rb.AddForce(0, 0, CorrectedForce(forwardForce));
        }
        if (Input.GetKey("s")) {
            rb.AddForce(0, 0, CorrectedForce(-forwardForce));
        }
        if (Input.GetKey("d")) {
            rb.AddForce(CorrectedForce(sidewaysForce), 0, 0);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(CorrectedForce(-sidewaysForce), 0, 0);
        }
        if (Input.GetKeyDown("space") && canJump) {
            rb.AddForce(0, CorrectedForce(jumpStrength), 0);
            rb.AddForce(0, 0, 0);
        }
    }
    float CorrectedForce(float force) {
        return force * Time.deltaTime;
    }
}
