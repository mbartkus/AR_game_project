using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstCollision : MonoBehaviour
{
    public int obstacleCount;
   
    public Vector3 currentMovObjPos;
    [Range(0.05f, 0.5f)] public float CollisionDetectionRadius;
    public Vector3 currentObstObjPos;
    public Vector3 finishPointPos;
    public bool isGameRunningCol;
    public bool collided;
    public float maxDistance;
   
    int verticeCount;
    GameObject TempButtons;
    GameObject _MovingObject;
    GameObject _RetryMenu;
    GameObject _FinishMenu;
    public GameObject[] obstacleList;
    void Start()
    {
      
        TempButtons = GameObject.Find("TempButtonsParent");
        
        isGameRunningCol = false;
    }

     void Update()
    {
        if (isGameRunningCol == true) {
            
            for (int i = 0; (i < obstacleCount)&&collided==false; i++)
            {
                currentMovObjPos = _MovingObject.transform.position;
                currentObstObjPos = obstacleList[i].transform.position;

                if (Vector3.Distance(currentMovObjPos, currentObstObjPos) < CollisionDetectionRadius)
                {
                    collided = true;
                    isGameRunningCol = false;
                    _RetryMenu = GameObject.Find("RetryMenu");
                    _RetryMenu.GetComponent<RetryMenu>().MovableObjectCollided();
                    TempButtons.GetComponent<TempButtons>().SetChildInactive();
                }

                if (finishPointPos == currentMovObjPos)
                {
                    collided = true;
                    isGameRunningCol = false;
                    _FinishMenu = GameObject.Find("FinishMenu");
                    _FinishMenu.GetComponent<FinishMenu>().ShowSuccess();
                    TempButtons.GetComponent<TempButtons>().SetChildInactive();
                }
            }   
            
        }     
     }
   
    public void ReadyToDetectCollision()
    {
       Wait(1);
        obstacleList = GameObject.FindGameObjectsWithTag("Obstacles");
        _MovingObject = GameObject.Find("MovingObject");
        obstacleCount = obstacleList.Length ;
        verticeCount = _MovingObject.GetComponent<MovingObject>().verticesCount;
        finishPointPos = _MovingObject.GetComponent<MovingObject>().LastPos;
        isGameRunningCol = true;
        collided = false;
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
    

    


   