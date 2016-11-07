using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour
{
    private GameObject turret;

    public Color hovercolor;
    private Renderer rend;
    private Color Startcolor;
    

    void Start()
    {
        rend = GetComponent<Renderer>();
        Startcolor = rend.material.color;
        
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Nope");
            return;
        }
    }
    void OnMouseEnter()
    {
        rend.material.color = hovercolor;

    }
    void OnMouseExit()
    {
        rend.material.color = Startcolor;
    }
}
