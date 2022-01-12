using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

using System.Runtime.Serialization.Formatters.Binary;


public class SaveLoadManager : MonoBehaviour
{


    public void SaveData()
    {
        SerializedData myserializedData = new SerializedData();

        myserializedData.ser_score = GameData.GameScore;
        myserializedData.ser_lives = GameData.Lives;
        myserializedData.ser_hscore = GameData.HighScore;

        BinaryFormatter bf = new BinaryFormatter();

        Debug.Log(Application.persistentDataPath.ToString());
        FileStream file = File.Create(Application.persistentDataPath + "/gamedata.save");

        bf.Serialize(file, myserializedData);
        file.Close();
        Debug.Log("GAME SAVED");


      // JSON to playerprefs method:

      //  string jsontosave = JsonUtility.ToJson(myserializedData);  //parsing the serializedData class to a JSON string
      //  Debug.Log(jsontosave);
      //  PlayerPrefs.SetString("MSD61A_TanksData", jsontosave);

    }

    public void LoadData()
    {
       // string loadedjson;

        SerializedData loadedData = new SerializedData();

        if (File.Exists(Application.persistentDataPath + "/gamedata.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamedata.save", FileMode.Open);

            loadedData = (SerializedData)bf.Deserialize(file);
            file.Close();


            if (loadedData != null)
            {
                GameData.GameScore = loadedData.ser_score;
                GameData.Lives = loadedData.ser_lives;
                GameData.HighScore = loadedData.ser_hscore;
            }

            // playerprefs to JSON to serializeddata loading method:

            //    loadedjson = PlayerPrefs.GetString("MSD61A_TanksData");  //load the string in registry to loadedjson attribute
            //    myserializedData = JsonUtility.FromJson<SerializedData>(loadedjson);  //parsing JSON string back to serializedData class 
           
        }


    }


}
