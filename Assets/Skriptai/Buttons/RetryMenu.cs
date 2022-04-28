using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryMenu : MonoBehaviour
{

    void Awake()
    {
     SetRetryMenuInactive();
    }
   public void  MovableObjectCollided()
    {
     gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void SetRetryMenuInactive()
    {
     gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
    public void Retry()
    {
        GameObject MgameObject = GameObject.Find("MovingObject");
        MgameObject.GetComponent<MovingObject>().Retry();
    }

} 
