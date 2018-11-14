using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float movementSpeed;
    public float rotSpeed;

    void Update ()
    {

        //Player movement.
		if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward.normalized * movementSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back.normalized * movementSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left.normalized * movementSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right.normalized * movementSpeed * Time.deltaTime);
        }

        //Looking around - Left and Right
        //Used for Player rotation - since the Mouse will be used for clicking on objects within the world.
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down.normalized * rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up.normalized * rotSpeed * Time.deltaTime);
        }
    }
}
