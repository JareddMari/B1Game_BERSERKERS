using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scor : MonoBehaviour
{

    public Text score;
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void RollDice()
    {
        int number = Random.Range(1, 7);
        score.text = number.ToString();
        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {


            PlayerPrefs.SetInt("HightScore", number);
            highScore.text = number.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
