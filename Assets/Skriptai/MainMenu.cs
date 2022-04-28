using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayLevel()
    {//galima padaryti secene queue +1
        SceneManager.LoadScene("AR_Game_Scene");
    }

    public void ShowTutorial()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        gameObject.transform.GetChild(4).gameObject.SetActive(true);
    }
    public void ReturnToMainMenu()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }


    // Start is called before the first frame update
    // void Start()


    // Update is called once per frame
    // void Update()


}