using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MouseClick_MAP : MonoBehaviour
{
    public Canvas SouthAmerica, NorthAmerica, Europe, Asia, Australia, Africa, Construction;
    private UserSettings m_settings;
    private void Start()
    {

//        m_settings.GetComponent<UserSettings>();
        SouthAmerica.enabled = false;
        NorthAmerica.enabled = false;
        Europe.enabled = false;
        Asia.enabled = false;
        Australia.enabled = false;
        Africa.enabled = false;
        Construction.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SouthAmerica.enabled = false;
            NorthAmerica.enabled = false;
            Europe.enabled = false;
            Asia.enabled = false;
            Australia.enabled = false;
            Africa.enabled = false;
            Construction.enabled = false;
        }
        
        
        if(Input.GetMouseButtonDown(0))
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
    }

    private void obj(GameObject go)
    {
        print("User has clicked on continent: "+go.name);
        
        if (go.tag == "SouthAmerica")
        {
            SouthAmerica.enabled = true;
        }
        
        if (go.tag == "Asia")
        {
            Asia.enabled = true;
        }
        
        if (go.tag == "Europe")
        {
            Europe.enabled = true;
        }
        
        if (go.tag == "NorthAmerica")
        {
            NorthAmerica.enabled = true;
        }
        
        if (go.tag == "Australia")
        {
            Australia.enabled = true;
        }
        
        if (go.tag == "Africa")
        {
            Africa.enabled = true;
        }
        
        if (go.tag == "Construction")
        {
            Construction.enabled = true;
        }
    }
}
