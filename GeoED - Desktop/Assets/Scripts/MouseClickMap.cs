using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MouseClickMap : MonoBehaviour
{

    public Canvas SouthAmerica;
    public Canvas InDevelopment;

    private void Start()
    {
        SouthAmerica.enabled = false;

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mousebutton zero is the left mouse button.
        {
            RaycastHit hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    ClickObj(hit.transform.gameObject);
                }
            }
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SouthAmerica.enabled = false;
        }
    } 

    private void ClickObj(GameObject continent)
    {
        if (continent.tag == "Continent")
        {
            SouthAmerica.enabled = true;
        }
        else
        {
            print("Nothing was clicked or is untagged as a continent!");
        }
    }
}
