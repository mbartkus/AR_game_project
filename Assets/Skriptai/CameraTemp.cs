using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraTemp : MonoBehaviour
{
    [SerializeField]
    GameObject prefabPlacable;
    GameObject tempPrefab;
    
    [Range(0f, 4f)] public float journeyLength;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void tempInstantiate()
    {

        tempPrefab = Instantiate(prefabPlacable);
    }
}
