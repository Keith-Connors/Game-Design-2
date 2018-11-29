using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.GlobalIllumination;
using Wilberforce;

public class UserSettings : MonoBehaviour
{
	private Colorblind m_colorBlind;
	private MouseClick_MAP m_CanvasRef;
	public Canvas PlayerSettings;
	public SpotLight sunRotation;


	public void loadNormalVision() //Normal
	{
		m_colorBlind.Type = 0;
	}

	public void loadProtanopiaVision() //Protanopia
	{
		m_colorBlind.Type = 1;
	}

	public void loadDeuteranopiaVision() //Deuteranopia
	{
		m_colorBlind.Type = 2;
	}

	public void loadTritanopiaVision() //Tritanopia
	{
		m_colorBlind.Type = 3;
	}
	
	void Start ()
	{
		PlayerSettings.enabled = false;
		m_colorBlind = GetComponent<Colorblind>();
		m_CanvasRef = GetComponent<MouseClick_MAP>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Tab))
		{
			/*if (m_CanvasRef.Africa.enabled 
			    || m_CanvasRef.NorthAmerica.enabled 
			    || m_CanvasRef.SouthAmerica.enabled 
			    || m_CanvasRef.Europe.enabled
			    || m_CanvasRef.Asia.enabled
			    || m_CanvasRef.Australia.enabled
			    || m_CanvasRef.Construction.enabled)
			{
				m_CanvasRef.Africa.enabled = false;
					m_CanvasRef.NorthAmerica.enabled = false; 
					m_CanvasRef.SouthAmerica.enabled  = false;
					m_CanvasRef.Europe.enabled = false;
					m_CanvasRef.Asia.enabled = false;
					m_CanvasRef.Australia.enabled = false;
					m_CanvasRef.Construction.enabled = false;
			}*/
			PlayerSettings.enabled = true;
			if (!EventSystem.current.IsPointerOverGameObject())
			{
				
			}
		}
		
		if (Input.GetKey(KeyCode.Escape))
		{
			PlayerSettings.enabled = false;
		}

		if (Input.GetKey(KeyCode.P)) 
		{
			m_colorBlind.Type = 0; //Normal
		}
		if (Input.GetKey(KeyCode.O))
		{
			m_colorBlind.Type = 1; //Protanopia
		}
		if (Input.GetKey(KeyCode.I))
		{
			m_colorBlind.Type = 2; //Deuteranopia
		}
		if (Input.GetKey(KeyCode.U))
		{
			m_colorBlind.Type = 3; //Tritanopia
		}
	}
}
