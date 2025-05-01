using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    public Text scoreText;
    public Text nameText;
    public Text bestScoreText;
    private int bestScore;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("score"))
        {
            bestScoreText.text = "Best Score: "+PlayerPrefs.GetString("score");
        }
        else
        {
            bestScoreText.text = "Best Score: " + 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        
        nameText.text = "Name: " + Username.Instance.InputUsername;
    }
    public void GetHighscore()
    {
        if (PlayerPrefs.HasKey("score"))
        {


            if (int.Parse(scoreText.text) > int.Parse(bestScoreText.text))
            {
                PlayerPrefs.SetString("score", scoreText.text);
            }
        }
        else
        {
            PlayerPrefs.SetString("score", scoreText.text);
        }
    }

}
