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
    //public Text scoreText;
    public Text nameText;
    public Text bestScoreText;
    private int bestScore;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("score"))
        {
            bestScore = PlayerPrefs.GetInt("score");
            bestScoreText.text = "Best Score: "+bestScore;
        }
        else
        {
            bestScore = 0;
            bestScoreText.text = "Best Score: " + bestScore;
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
    public void GetHighscore(int scoreTotal)
    {
        if (PlayerPrefs.HasKey("score"))
        {


            if (scoreTotal > bestScore)
            {
                bestScore = scoreTotal;
                PlayerPrefs.SetInt("score", bestScore);
                
                bestScoreText.text = "Best Score: " + bestScore;
            }
        }
        else
        {
            bestScore = scoreTotal;
            PlayerPrefs.SetInt("score", bestScore);
            bestScoreText.text = "Best Score: " + bestScore;
        }
    }

}
