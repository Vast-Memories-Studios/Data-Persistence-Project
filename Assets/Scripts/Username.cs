using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Username : MonoBehaviour
{
    public string InputUsername;
    public static Username Instance;
    public string Highscore;
    public string highscoreCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void CreateUsername(string User)
    {
        InputUsername = User;
        
    }
    [System.Serializable]
    class SaveData
    {
        public string Highscore;
    }
    public void SaveHighScore()
    {
        SaveData data = new SaveData();

        data.Highscore = Highscore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadHighscore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Highscore = data.Highscore;
        }
    }
    public void HighscoreCheck()
    {

    }
}
