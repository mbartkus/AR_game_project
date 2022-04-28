using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPlacement : MonoBehaviour
{
    public void ActivateChild()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void SetChildInactive()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }

}
