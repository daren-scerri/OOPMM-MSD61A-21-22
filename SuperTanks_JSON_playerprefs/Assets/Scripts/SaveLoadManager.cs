using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    SerializedData myserializedData;
    void Start()
    {
        myserializedData = new SerializedData();
    }

    public void SaveData()
    {
        myserializedData.ser_score = GameData.GameScore;
        myserializedData.ser_lives = GameData.Lives;
        myserializedData.ser_hscore = GameData.HighScore;
        string jsontosave = JsonUtility.ToJson(myserializedData);  //parsing the serializedData class to a JSON string
        Debug.Log(jsontosave);
        PlayerPrefs.SetString("MSD61A_TanksData", jsontosave);

    }

    public void LoadData()
    {
        string loadedjson;

        if (PlayerPrefs.HasKey("MSD61A_TanksData"))
        {
            loadedjson = PlayerPrefs.GetString("MSD61A_TanksData");  //load the string in registry to loadedjson attribute
            myserializedData = JsonUtility.FromJson<SerializedData>(loadedjson);  //parsing JSON string back to serializedData class 
            GameData.GameScore = myserializedData.ser_score;
            GameData.Lives = myserializedData.ser_lives;
            GameData.HighScore = myserializedData.ser_hscore;
        }


    }


}
