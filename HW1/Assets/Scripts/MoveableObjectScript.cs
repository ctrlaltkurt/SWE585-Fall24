using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObjectScript : MonoBehaviour
{
    // Variable to hold a reference to the object's Rigidbody
    public Rigidbody rb;

    // Force amount
    public Vector3 force = new Vector3(0, 0, 10);

    // Start is called before the first frame update
    void Start()
    {
        // If rb hasn't been set in the Inspector, find it on this GameObject
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Apply force to the Rigidbody every frame
        rb.AddForce(force);
    }
}

