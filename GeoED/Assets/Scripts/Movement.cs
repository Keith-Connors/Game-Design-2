using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) // Left and Right movement
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0f, 0f)); //Movement is only effected by the X
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) // Up and Down movement
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime, 0f)); //Movement is only effected by the Y
        }
    }
}
