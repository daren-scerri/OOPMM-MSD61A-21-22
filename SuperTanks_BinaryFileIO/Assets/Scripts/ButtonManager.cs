using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    //Make sure to attach these Buttons in the Inspector
    [SerializeField] Button startButton, exitButton;

    void Start()
    {
        //Calls the StartGame or QuitGame method when you click the Button
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(QuitGame);      
    }

    void StartGame()
    {
        //Output this to console when Button1 is clicked
        Debug.Log("You have clicked the start button!");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        //Output this to console when Button1 is clicked
        Debug.Log("You have clicked the quit button!");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif

    }

}
