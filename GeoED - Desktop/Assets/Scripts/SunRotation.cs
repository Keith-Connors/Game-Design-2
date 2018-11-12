using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour
{
    //This is only a temporary class and is not meant to represent final faux lighting for the continents.

    public float angle;
	void Update ()
    {
        transform.RotateAround(Vector3.zero, Vector3.up , angle * Time.deltaTime);
    }
}
