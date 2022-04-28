using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FloatWallObstFront : MonoBehaviour
{
    public float lerpPercentage;
    public float startingTime;
    public float lerpDist;
    public Vector3 State1Pos;
    public Vector3 State2Pos;
    public float offsetMoveX;
    public float offsetMoveY;
    [Range(0.01f, 1.0f)] public float speed;
    [Range(-0.5f, 0.5f)] public float offsetMoveZ;
    [Range(0, 1)] public int CurrentState;

    void Start()
    { 
        startingTime = Time.time;
        State1Pos = gameObject.transform.position;
        lerpDist = Vector3.Distance(State1Pos, State2Pos);
        State2Pos = new Vector3(State1Pos.x + offsetMoveX, State1Pos.y + offsetMoveY, State1Pos.z + offsetMoveZ);
    }
    void Update()
    {
        if (CurrentState == 0)
        {
            float timeDiff = Time.time - startingTime;
            lerpPercentage = timeDiff / lerpDist;
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, State1Pos, lerpPercentage * speed);
        }

        else
        {
            float timeDiff = Time.time - startingTime;
            lerpPercentage = timeDiff / lerpDist;
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, State2Pos, lerpPercentage * speed);
        }
    }

     public void ToggleState()
     {
        startingTime = Time.time;
        if (CurrentState == 0)
        {
            CurrentState = 1;
        }
        else
        {
            CurrentState = 0;
        }
     }
   

}


