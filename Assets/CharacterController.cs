using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10.0f;

    public float jumpStrength = 100000f;
    public bool canJump = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetButton("Jump") && canJump)
            rb.AddForce(0, jumpStrength, 0);


        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
