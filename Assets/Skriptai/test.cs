using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatVerWallObstLeft : MonoBehaviour
{
        // states: 0-default, 1-State1
        public int CurrentState = 1;
        // float obstFloatHeight;


        public float lerpPercentage;
        public float startingTime;
        public float lerpDist;
  
        public Vector3 State1Pos;
        public Vector3 State2Pos;
        public float offsetMoveX;
        public float offsetMoveY;
        public float offsetMoveZ;

        [Range(0.01f, 1.0f)] public float speed;




        //rasti bûda kaip statmenai plokstumai gauti koordinates

        void Start()
        {
            offsetMoveX = -0.3f;



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
            float timeDiff = Time.time - startingTime;
            lerpPercentage = timeDiff / lerpDist;
            if (CurrentState == 1)
            {
                gameObject.transform.position = Vector3.Lerp(State1Pos, State2Pos, lerpPercentage * speed);
            }
        }


    }
