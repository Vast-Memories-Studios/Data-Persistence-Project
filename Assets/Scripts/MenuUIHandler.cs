using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string username;
    public TMP_InputField inputuser;
    
  

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
    public void ReadStringInput()
    {
        username = inputuser.text;
        Debug.Log(username);
        Username.Instance.CreateUsername(username);
    }
}
