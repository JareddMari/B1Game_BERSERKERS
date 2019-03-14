using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uimanagerpause : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject VictoryMenu;
    public GameObject atomeInstable;

    // Use this for initialization
    void Start()
    {

        VictoryMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
          
            if (atomeInstable == null)
             {
            VictoryMenu.SetActive(true);
            Debug.Log(VictoryMenu);
             }
    }

    
    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        if (pauseMenu.activeSelf)
        {

            Time.timeScale = 0f;
        }
        else if (!pauseMenu.activeSelf)
        {
            Time.timeScale = 1f;
        }
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
