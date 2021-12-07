using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public interface ITakeDamage
{
    int health { get; set; }
    void TakeDamage(int damageamount);
}



public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    Text myscoreText;

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


    }

    // Start is called before the first frame update
    void Start()
    {
      myscoreText = GameObject.Find("ScoreText").GetComponent<Text>();
      myscoreText.text = "Score : " + GameData.Score.ToString();

    }


    public void IncreaseScore(int scorevalue)
    {
        GameData.Score = GameData.Score + scorevalue;
        // alternative shortcut:  GameData.Score += scorevalue;
        Debug.Log("Score : " + GameData.Score.ToString());
        myscoreText.text = "Score : " + GameData.Score.ToString();

    }

}
