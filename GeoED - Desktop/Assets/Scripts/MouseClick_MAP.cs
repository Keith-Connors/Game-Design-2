using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MouseClick_MAP : MonoBehaviour
{
    public Canvas SouthAmerica;

    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (hit.transform != null)
            {
                obj(hit.transform.gameObject);
            }
        }
    }

    private void obj(GameObject go)
    {
        print(go.name);
    }
}
