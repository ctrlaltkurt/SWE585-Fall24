using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variable to set the amount of force to apply
    public float moveForce = 10f;

    // Reference to the Rigidbody component
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player (WASD or Arrow keys)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the force vector based on input
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Apply force to the Rigidbody in the direction of the input
        rb.AddForce(movement * moveForce);
    }
}
