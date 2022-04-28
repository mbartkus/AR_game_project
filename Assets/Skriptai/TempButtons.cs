using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempButtons : MonoBehaviour
{
    public GameObject _FloatWallObstFront;
    public GameObject _FloatWallObstTop;
    public GameObject _FloatWallObstLeft;
    public GameObject _FloatWallObstRight;
    public GameObject _FloatWallObstBack;
    public GameObject _lockPlacementRef;
    public GameObject _MovingObject;

    
    // Start is called before the first frame update
    public void ActivateChild()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void ToggleLeft() 
    {
        _FloatWallObstLeft.GetComponent<FloatWallObstLeft>().ToggleState();
        _FloatWallObstBack.GetComponent<FloatWallObstBack>().ToggleState();
    }
    public void ToggleTop() 
    {
           _FloatWallObstTop.GetComponent<FloatWallObstTop>().ToggleState();
    }public void ToggleRight() 
    {
        _FloatWallObstRight.GetComponent<FloatWallObstRight>().ToggleState();
        _FloatWallObstTop.GetComponent<FloatWallObstTop>().ToggleState();
        _FloatWallObstLeft.GetComponent<FloatWallObstLeft>().ToggleState();
    }
    public void ToggleFront() 
    {
        _FloatWallObstFront.GetComponent<FloatWallObstFront>().ToggleState();
        _FloatWallObstTop.GetComponent<FloatWallObstTop>().ToggleState();
        _FloatWallObstLeft.GetComponent<FloatWallObstLeft>().ToggleState();
    }

    public void ToggleBack() { 
   
    _FloatWallObstBack.GetComponent<FloatWallObstBack>().ToggleState();
    _FloatWallObstFront.GetComponent<FloatWallObstFront>().ToggleState();
            }
    public void SetChildInactive()
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

    public void PressedStart()
    {
        _FloatWallObstLeft = GameObject.Find("FloatWallObstLeft");
        _FloatWallObstTop = GameObject.Find("FloatWallObstTop");
        _FloatWallObstFront = GameObject.Find("FloatWallObstFront");
        _FloatWallObstRight = GameObject.Find("FloatWallObstRight");
        _FloatWallObstBack = GameObject.Find("FloatWallObstBack");
     }
 } 


