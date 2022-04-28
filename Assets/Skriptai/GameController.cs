using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameController : MonoBehaviour
{
    GameObject _MovingObject;
    GameObject _ObstCollision;

public void ActivateTempButtons()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

public void StartIsPressed()
{
    _MovingObject = GameObject.Find("MovingObject");
    _ObstCollision = GameObject.Find("ObstCollision");
    _MovingObject.GetComponent<MovingObject>().PressedStartGame();
    _ObstCollision.GetComponent<ObstCollision>().ReadyToDetectCollision();
}

  public void ExitGame()
    {
        Application.Quit();
    }
}



  










