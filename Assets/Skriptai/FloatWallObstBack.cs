using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatWallObstBack : MonoBehaviour
{
    

    public float lerpPercentage;
    public float startingTime;
    public float lerpDist;
    
    public Vector3 State1Pos;
    public Vector3 State2Pos;
    public float offsetMoveX;
    public float offsetMoveY;
    public float offsetMoveZ;

    [Range(0.01f, 1.0f)] public float speed;
    [Range(0, 1)] public int CurrentState;



    //rasti bûda kaip statmenai plokstumai gauti koordinates

    void Start()
    {
        offsetMoveZ = 0.3f;
       
        startingTime = Time.time;
        State1Pos = gameObject.transform.position;
        lerpDist = Vector3.Distance(State1Pos, State2Pos);

        //bus galima IF statement priklausomai nuo plokstumos padeties i kuria puse didint
        State2Pos = new Vector3(State1Pos.x + offsetMoveX, State1Pos.y + offsetMoveY, State1Pos.z + offsetMoveZ);
        // State2Pos = new Vector3(-0.081f,0.824f, -0.093f);

    }

    // Update is called once per frame
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
