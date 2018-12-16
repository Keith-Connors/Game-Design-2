using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseClick_MAP : MonoBehaviour
{
    [Header("Continent Canvas")]
    public Canvas SouthAmerica, NorthAmerica, Europe, Asia, Australia, Africa, Construction;

    [Header("Information Panel")]
    public GameObject  //Panels for information.
        ContinentInfo,
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
    [Header("Buttons")]
    public Button ArgentinaInfo1,
        BoliviaInfo1,
        BrazilInfo1,
        ChileInfo1,
        ColombiaInfo1,
        EcuadorInfo1,
        GuyanaInfo1,
        ParaguayInfo1,
        PeruInfo1,
        SurinameInfo1,
        UruguayInfo1,
        VenezuelaInfo1;

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

        ArgentinaInfo.active = false;
        BoliviaInfo.active = false;
        BrazilInfo.active = false;
        ChileInfo.active = false;
        ColombiaInfo.active = false;
        EcuadorInfo.active = false;
        GuyanaInfo.active = false;
        ParaguayInfo.active = false;
        PeruInfo.active = false;
        SurinameInfo.active = false;
        UruguayInfo.active = false;
        VenezuelaInfo.active = false;

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



        if(SouthAmerica.enabled)
        {
            //SouthAmerica.enabled = false;
            NorthAmerica.enabled = false;
            Europe.enabled = false;
            Asia.enabled = false;
            Australia.enabled = false;
            Africa.enabled = false;
            Construction.enabled = false;
        }

        if (NorthAmerica.enabled)
        {
            SouthAmerica.enabled = false;
            //NorthAmerica.enabled = false;
            Europe.enabled = false;
            Asia.enabled = false;
            Australia.enabled = false;
            Africa.enabled = false;
            Construction.enabled = false;
        }
        if (Europe.enabled)
        {
            SouthAmerica.enabled = false;
            NorthAmerica.enabled = false;
            //Europe.enabled = false;
            Asia.enabled = false;
            Australia.enabled = false;
            Africa.enabled = false;
            Construction.enabled = false;
        }
        if (Asia.enabled)
        {
            SouthAmerica.enabled = false;
            NorthAmerica.enabled = false;
            Europe.enabled = false;
            //Asia.enabled = false;
            Australia.enabled = false;
            Africa.enabled = false;
            Construction.enabled = false;
        }
        if (Australia.enabled)
        {
            SouthAmerica.enabled = false;
            NorthAmerica.enabled = false;
            Europe.enabled = false;
            Asia.enabled = false;
            //Australia.enabled = false;
            Africa.enabled = false;
            Construction.enabled = false;
        }
        if (Africa.enabled)
        {
            SouthAmerica.enabled = false;
            NorthAmerica.enabled = false;
            Europe.enabled = false;
            Asia.enabled = false;
            Australia.enabled = false;
           // Africa.enabled = false;
            Construction.enabled = false;
        }
        if (Construction.enabled)
        {
            SouthAmerica.enabled = false;
            NorthAmerica.enabled = false;
            Europe.enabled = false;
            Asia.enabled = false;
            Australia.enabled = false;
            Africa.enabled = false;
            //Construction.enabled = false;
        }

        if (Input.GetMouseButtonDown(0))
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
