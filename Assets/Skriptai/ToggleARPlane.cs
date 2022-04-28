using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]
public class ToggleARPlane : MonoBehaviour
{
    private ARPlaneManager arPlaneObj;
    public bool RenderingDisabled;
    // Start is called before the first frame update
    void Awake()
    {
        arPlaneObj = GetComponent<ARPlaneManager>();
        RenderingDisabled = false;
    }



    void Update()
    {
       
        if (RenderingDisabled == true)
        {
            foreach (var plane in arPlaneObj.trackables)
            {
                plane.gameObject.SetActive(false);
            }
        }
    }

       
     

        //private void SetAllPlanesActive(bool value) 
        //{
        //    foreach (var plane in arPlaneObj.trackables)   
        //    {
        //        plane.gameObject.SetActive(value);
        //    }
        //}


    
    public void ToggleVisualization()
    {

        RenderingDisabled = true; 
    }

    

}



