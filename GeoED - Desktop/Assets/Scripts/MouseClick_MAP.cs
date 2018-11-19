using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MouseClick_MAP : MonoBehaviour
{
    private Canvas _SouthAmerica;

    private void Start()
    {
        //SouthAmerica = GetComponent<Canvas>();
        _SouthAmerica.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    //Do stuff
                }
            }
        }
    }

    private void CheckObj(GameObject go)
    {
        if (go.name == "SouthAmerica" || go.tag == "SouthAmerica")
        {
            _SouthAmerica.enabled = true;
        }
    }
}
