using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string username;


    private void Start()
    {

    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        
        EditorApplication.ExitPlaymode();

#else

        Application.Quit();

#endif

    }
    public void ReadStringInput(string user)
    {
        Username.Instance.InputUsername = user;
        Debug.Log(username);
    }
}
