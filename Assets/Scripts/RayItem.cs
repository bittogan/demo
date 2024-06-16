using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayItem : MonoBehaviour , IRayItem
{
    [SerializeField] Color deActiveColor;
    [SerializeField] Color activeColor;
    [SerializeField] Renderer gameObjectRenderer;
    // Start is called before the first frame update
    public void Start()
    {
        //gameObjectRenderer = GetComponent<Renderer>();
        gameObjectRenderer.material.color = deActiveColor;
    }
    public void OnPointerEnter()
    {
        Debug.Log("OnPointerEnter");
        gameObjectRenderer.material.color = activeColor;
    }
        
    // Update is called once per frame
    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit");
        gameObjectRenderer.material.color = deActiveColor   ;
    }
}
