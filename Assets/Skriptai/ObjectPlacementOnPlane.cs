using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ObjectPlacementOnPlane : MonoBehaviour
{
    public bool PlacementLocked;
    GameObject _ObstscaleTriggering;
    [SerializeField]
    private GameObject gameObjectToSpawn;
    private GameObject PlacedPrefab;
    private ARRaycastManager arRaycastManager; // kad butu instancas kuriame laikomas bus raycastas
    private Vector2 tapPosition;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Start()
    {
        arRaycastManager = GetComponent<ARRaycastManager>(); //pasiemamas is requireComponent
        PlacementLocked = false;
        _ObstscaleTriggering = GameObject.Find("AR Session Origin");
        PlacedPrefab = null;
    }
    //bool IsPointOverUIObject(Vector2 pos)
    //{
    //    if (EventSystem.current.IsPointerOverGameObject())
    //        return false;

    //    PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
    //    eventDataCurrentPosition.position = new Vector2(pos.x, pos.y);
    //    List<RaycastResult> results = new List<RaycastResult>();
    //    EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
    //    return results.Count > 0;
    //}
    // Update is called once per frame
    void Update()
    {
        if (PlacementLocked == false)
        {
            if (!GettingTapPosition(out Vector2 tapPosition))
                return;

            if (((PlacementLocked == false) && arRaycastManager.Raycast(tapPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))) // (pradinis pos, colliderris, direction)
            {
                var hitPose = hits[0].pose;
                if (PlacedPrefab == null )
                {
                    PlacedPrefab = Instantiate(gameObjectToSpawn, hitPose.position, hitPose.rotation);
                }
                else
                {
                    Destroy(PlacedPrefab);
                    PlacedPrefab = Instantiate(gameObjectToSpawn, hitPose.position, hitPose.rotation);
                }
            }
        }
    }
    bool GettingTapPosition(out Vector2 tapPosition)
    {
        if (Input.touchCount > 0)
        {
            tapPosition = Input.GetTouch(0).position;
            return true;
        }
        tapPosition = default;
        return false;
    }
    public void LockInPlace()
    {
        PlacementLocked = true;
        _ObstscaleTriggering.GetComponent<ObstacleTriggering>().PlacementLocked();
        
    }
}



   


    

