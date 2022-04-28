using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    LineRenderer lineRendererComp = new LineRenderer();
  
    [SerializeField] public Vector3 finishPointPos;
                     public Vector3 MovingObjectPos;
                     int posCount;

    // Start is called before the first frame update
    void Start()
    {
      
        posCount = lineRendererComp.GetComponent<LineRenderer>().positionCount;

        finishPointPos = lineRendererComp.GetComponent<LineRenderer>().GetPosition(posCount - 1);

        MovingObjectPos = GameObject.Find("MovingObject").transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        if (MovingObjectPos == finishPointPos) {
            
            
        }
            // Pergalë
    }
}
