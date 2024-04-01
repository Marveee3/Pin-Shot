using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount;
    private Text scoreText;
    [SerializeField]private Text highScoreText;

    void Start()
    {   
        scoreText = GetComponent<Text>();
        pinCount = 0;
        highScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = pinCount.ToString();
        if(pinCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", pinCount);
        }
    }

}
