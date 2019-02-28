using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uimanagerpause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Resume()
    {
        SceneManager.LoadScene("Berserk");
    }
    public void CQuit()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
