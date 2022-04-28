using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishMenu : MonoBehaviour
{
    private void Awake()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
    public void ShowSuccess()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void ShowSoon()
    {
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

}
