using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayToStart : MonoBehaviour
{
    
    // Start is called before the first frame update
    
 public void ActivateChild() 
    {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
 public void SetChildInactive()
    {
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

}

// Update is called once per frame




