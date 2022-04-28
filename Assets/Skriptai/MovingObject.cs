using UnityEngine;
using System.Linq;
public class MovingObject : MonoBehaviour
{
    GameObject _LockPlacement;
    GameObject _ObstTriggering;
    public bool isGameRunning;
    [SerializeField] [Range(0f, 4f)] public float journeyLength;
    public float speed = 1.0f;
    public float startTime;
    public int verticesCount;
    public GameObject[] listOfVertices;
    public Vector3[] waypointsXYZ;
    public float journeyFraction;
    float totalDestinationDistance;
    public Vector3 lerpPos1;
    public Vector3 lerpPos2;
    public Vector3 currentPos;
    public Vector3 LastPos;
    public int i; 

   public void Start()
    {
        isGameRunning = false;
        _LockPlacement = GameObject.Find("LockPlacement");
        i = 0;
    }

    void Update()
    {
        CheckIfGameStopped();
       
        if (isGameRunning == true)
        {
            lerpPos1 = waypointsXYZ[i];
            lerpPos2 = waypointsXYZ[i+1];
            currentPos = transform.position;
       
            float currentDuration = Time.time - startTime;
            journeyFraction = currentDuration / totalDestinationDistance;

            transform.position = Vector3.Lerp(lerpPos1, lerpPos2, journeyFraction * speed);
            if (currentPos == lerpPos2 && i <= verticesCount)
            {
                i++;
                startTime = Time.time;
                totalDestinationDistance = Vector3.Distance(lerpPos1, lerpPos2);
            }
        }
        if (i == verticesCount - 1)//kad nebebandytu deti i array, minusas nes array nuo 0 prasideda
        {
            isGameRunning = false;
        }
    }

    void TracePathCoords() {
        listOfVertices = GameObject.FindGameObjectsWithTag("Vertices").OrderBy(go => go.name).ToArray();
        verticesCount = listOfVertices.Length;
        waypointsXYZ = new Vector3[(verticesCount)];
        waypointsXYZ[0] = listOfVertices[0].transform.position;
        for (int i = 0; i < (verticesCount); i++)
        {
            waypointsXYZ[i] = listOfVertices[i].transform.position;
        }
        totalDestinationDistance = Vector3.Distance(waypointsXYZ[0], waypointsXYZ[1]);
        LastPos = listOfVertices[verticesCount - 1].transform.position;
    }
    void CheckIfGameStopped()
    {
        if (GameObject.Find("ObstCollision").GetComponent<ObstCollision>().collided == true)
        {
            isGameRunning = false;
        }
    }
    public void PressedStartGame()
    {
        TracePathCoords();
        isGameRunning = true;
       // _ObstTriggering = GameObject.Find("AR Session Origin");
     //   _ObstTriggering.GetComponent<ObstacleTriggering>().PrepObstReferences();

    }
    public void Retry()
    {
        i = 0;
        //hardcoded start positions
        gameObject.transform.position = new Vector3(-0.202999994f, -0.799000025f, -0.326000005f);

     
    }
 
   


}