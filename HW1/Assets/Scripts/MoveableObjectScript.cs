using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObjectScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Move the object up when the 'W' key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
    }
}

