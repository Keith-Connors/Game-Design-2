using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class MouseClickIntro : MonoBehaviour
{
    
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
    } 

    private void ClickObj(GameObject go)
    {
        if (go.tag == "Continent")
        {
            SceneManager.LoadScene("Map");
        }
        else
        {
            print(go);
        }
    }
}
