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
    // Start is called before the first frame update
    void Start()
    {
        
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

        Username.Instance.highscoreCheck = bestScoreText.text;
    }

}
