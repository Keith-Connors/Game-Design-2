using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseClick_MAP : MonoBehaviour
{
    [Header("Continent Canvas")]
    public Canvas SouthAmerica, NorthAmerica, Europe, Asia, Australia, Africa, Construction;

    [Header("Information Panel")]
    public GameObject  //Panels for information.
        ArgentinaInfo,
        BoliviaInfo,
        BrazilInfo,
        ChileInfo,
        ColombiaInfo,
        EcuadorInfo,
        GuyanaInfo,
        ParaguayInfo,
        PeruInfo,
        SurinameInfo,
        UruguayInfo,
        VenezuelaInfo;
    
    public bool mapEnabled = true;
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
            mapEnabled = true;
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
        
        if (go.tag == "SouthAmerica" && mapEnabled == true)
        {
            SouthAmerica.enabled = true;
            mapEnabled = false;
        }
        
        if (go.tag == "Asia" && mapEnabled == true)
        {
            Asia.enabled = true;
            mapEnabled = false;
        }
        
        if (go.tag == "Europe" && mapEnabled == true)
        {
            Europe.enabled = true;
            mapEnabled = false;
        }

        if (go.tag == "NorthAmerica" && mapEnabled == true) 
        {
            NorthAmerica.enabled = true;
            mapEnabled = false;
        }
        
        if (go.tag == "Australia" && mapEnabled == true)
        {
            Australia.enabled = true;
            mapEnabled = false;
        }
        
        if (go.tag == "Africa" && mapEnabled == true)
        {
            Africa.enabled = true;
            mapEnabled = false;
            
        }
        
        if (go.tag == "Construction" && mapEnabled == true)
        {
            Construction.enabled = true;
            mapEnabled = false;
        }
    }
}
