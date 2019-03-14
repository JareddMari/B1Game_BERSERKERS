using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    public float currentTime;
    public Text tempsFinal;
    public Text score;
    
    // Use this for initialization
    void Start () {
        tempsFinal.text = PlayerPrefs.GetInt("TempsMis", 0).ToString();
    }
   
    


    // Update is called once per frame
    void Update () {
        
        currentTime += Time.deltaTime;
        score.text = currentTime.ToString();
        tempsFinal.text = currentTime.ToString();
        
        
    }

    
}
