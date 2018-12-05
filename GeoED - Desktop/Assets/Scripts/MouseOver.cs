using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshRenderer))]
public class MouseOver : MonoBehaviour 
{
/*
 * Script needs to be attached to a GameObject with a MeshRenderer.
 *
 */
  
    Color m_MouseOverColor = Color.white;

    Color m_OriginalColor;

    MeshRenderer m_Renderer;

    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    private void Update()
    {
        
    }

    void OnMouseOver()
    {
        m_Renderer.material.color = m_MouseOverColor;
    }

    void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }

}
