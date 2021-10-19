using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject myballPrefab;
    private float xpos = 0;
    private float xmin, ymin, xmax, ymax;
    // Start is called before the first frame update
    void Start()
    {    //load the 'ball' prefab from resources folder in project
        myballPrefab = Resources.Load("ball") as GameObject;

        Camera mycamera = Camera.main;

        xmin = mycamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x;
       


    }

    // Update is called once per frame
    void Update()
    {
        xpos = Random.Range(xmin, xmax);

        //instantiate a new gameobject from the loaded prefab at the top of the scene
        Instantiate(myballPrefab, new Vector3(xpos, 10f, 0f), Quaternion.identity);
    }
}


