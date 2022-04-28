using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;



[RequireComponent(typeof(ARRaycastManager))]
public class ObstacleTriggering : MonoBehaviour
{
    
    private ARRaycastManager arRaycastManager; // kad butu instancas kuriame laikomas bus raycastas
    //  public Vector2 tapPosition;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>(); 
    public GameObject FloatWallObstFront;
    public GameObject FloatWallObstTop;
    public GameObject FloatWallObstLeft;
    public GameObject FloatWallObstRight;
    public GameObject FloatWallObstBack;
    public bool PlacementIsLocked;

   public void Start()
   {

        PlacementIsLocked = false;

    }
    void Update()
    {    
        if (PlacementIsLocked == true)
            {
            //if (Input.GetMouseButtonDown(0))
            //{
            //    RaycastHit HitObjectinfo;
            //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //    if (Physics.Raycast(ray, out HitObjectinfo))

            if (Input.touchCount > 0)
            {
                Touch tap = Input.GetTouch(0);
                RaycastHit HitObjectinfo;
                Ray ray = Camera.main.ScreenPointToRay(tap.position);
                if (Physics.Raycast(ray, out HitObjectinfo))

                {
                    if (HitObjectinfo.collider.name == ("FrontObstTrigerButton")&&(GameObject.Find("MovingObject").GetComponent<MovingObject>().isGameRunning == false))
                    {
                        FloatWallObstFront.GetComponent<FloatWallObstFront>().ToggleState();
                        FloatWallObstTop.GetComponent<FloatWallObstTop>().ToggleState();
                        FloatWallObstLeft.GetComponent<FloatWallObstLeft>().ToggleState();
                    }
                    else if (HitObjectinfo.collider.name == ("TopObstTrigerButton") && (GameObject.Find("MovingObject").GetComponent<MovingObject>().isGameRunning == false))
                    {
                        FloatWallObstTop.GetComponent<FloatWallObstTop>().ToggleState();
                    }
                    else if (HitObjectinfo.collider.name == ("LeftObstTrigerButton") && (GameObject.Find("MovingObject").GetComponent<MovingObject>().isGameRunning == false))
                    {
                        FloatWallObstLeft.GetComponent<FloatWallObstLeft>().ToggleState();
                        FloatWallObstBack.GetComponent<FloatWallObstBack>().ToggleState();
                    }
                    else if (HitObjectinfo.collider.name == ("RightObstTrigerButton") && (GameObject.Find("MovingObject").GetComponent<MovingObject>().isGameRunning == false))
                    {
                        FloatWallObstRight.GetComponent<FloatWallObstRight>().ToggleState();
                        FloatWallObstTop.GetComponent<FloatWallObstTop>().ToggleState();
                        FloatWallObstLeft.GetComponent<FloatWallObstLeft>().ToggleState();
                    }
                    else if (HitObjectinfo.collider.name == ("BackObstTrigerButton") && (GameObject.Find("MovingObject").GetComponent<MovingObject>().isGameRunning == false))
                    {
                        FloatWallObstBack.GetComponent<FloatWallObstBack>().ToggleState();
                        FloatWallObstFront.GetComponent<FloatWallObstFront>().ToggleState();
                    }
                  }
            }
        }
       
     }

    public void PlacementLocked()
    {
     PlacementIsLocked = true;
        Wait(2);
        FloatWallObstFront = GameObject.Find("FloatWallObstFront");
        FloatWallObstTop = GameObject.Find("FloatWallObstTop");
        FloatWallObstLeft = GameObject.Find("FloatWallObstLeft");
        FloatWallObstRight = GameObject.Find("FloatWallObstRight");
        FloatWallObstBack = GameObject.Find("FloatWallObstBack");
    }
    public void PrepObstReferences()
    {
        //FloatWallObstFront = GameObject.Find("FloatWallObstFront");
        //FloatWallObstTop = GameObject.Find("FloatWallObstTop");
        //FloatWallObstLeft = GameObject.Find("FloatWallObstLeft");
        //FloatWallObstRight = GameObject.Find("FloatWallObstRight");
        //FloatWallObstBack = GameObject.Find("FloatWallObstBack");
    }
    IEnumerator Wait(float duration)
    {
        //This is a coroutine
        Debug.Log("Start Wait() function. The time is: " + Time.time);
        Debug.Log("Float duration = " + duration);
        yield return new WaitForSeconds(duration);   //Wait
        Debug.Log("End Wait() function and the time is: " + Time.time);
    }

}





