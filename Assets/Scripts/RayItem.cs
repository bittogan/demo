using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayItem : MonoBehaviour , IRayItem
{
    // Start is called before the first frame update
    public void OnPointerEnter()
    {
        Debug.Log("OnPointerEnter");
    }
        
    // Update is called once per frame
    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit");
    }
}
