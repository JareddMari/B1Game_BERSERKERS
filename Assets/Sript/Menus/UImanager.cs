using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        SceneManager.LoadScene("Level2Building");
    }
    public void Command()
    {
        SceneManager.LoadScene(5);
    }

    public void Leave()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene(3);
    }


    public void BackToMainMenu()

    {
        SceneManager.LoadScene(0);
    }

    public void Done()
    {
        SceneManager.LoadScene(0);
    }
}
