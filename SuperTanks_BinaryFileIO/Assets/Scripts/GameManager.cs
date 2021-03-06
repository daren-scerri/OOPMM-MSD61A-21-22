using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField] Text playerScoreText;

    [SerializeField] Text livesText;

    [SerializeField] GameObject playerPrefab;

    public static GameManager _instance;

    void Awake()
    {

        //SINGLETON PATTERN - ensure you have only one instance of a class

        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this.gameObject);
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(this.gameObject);
      
    }




    // Use this for initialization
    void Start () {
        GameData.HighScore = 0;
        GameData.GameScore = 0;
        GameData.Lives = 3;
        GetComponent<SaveLoadManager>().LoadData();
        playerScoreText.text = "Score: " + GameData.GameScore.ToString();
        livesText.text = "Lives: " + GameData.Lives.ToString();
	}

    public void OnEnemyDie()
    {
      
        GameData.GameScore++;
        playerScoreText.text = "Score: " + GameData.GameScore.ToString();
        GetComponent<SaveLoadManager>().SaveData();
    }

    public void OnFixedEnemyDie()
    {
        
        SceneManager.LoadScene("Win");

    }

    public void OnPlayerDie()
    {
        GameData.Lives--;
        livesText.text = "Lives: " + GameData.Lives.ToString();
        GetComponent<SaveLoadManager>().SaveData();
        if (GameData.Lives > 0) Instantiate(playerPrefab, new Vector3(-5f, 0f, 0f), Quaternion.identity);
        else SceneManager.LoadScene("GameOver");
      
    }
    // Update is called once per frame
    void Update () {

        

    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "GameOver" || scene.name == "Win")
        {
            print("Score = " + GameData.GameScore.ToString());
            Text myscoretext = GameObject.Find("Scoretext").GetComponent<Text>();
            myscoretext.text = "Score: " + GameData.GameScore.ToString();
            if (GameData.GameScore > GameData.HighScore) GameData.HighScore = GameData.GameScore;
            Text myhighscoretext = GameObject.Find("Highscoretext").GetComponent<Text>();
            myhighscoretext.text = "High Score: " + GameData.HighScore.ToString();

            GameData.GameScore = 0;
            GameData.Lives = 3;
            GetComponent<SaveLoadManager>().SaveData();

           
        }
    }
}
