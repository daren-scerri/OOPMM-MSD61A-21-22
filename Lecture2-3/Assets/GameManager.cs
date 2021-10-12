using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private GameObject myprefab;
    private float xpos = 0;
    private float xmin, xmax;
    private Camera mycamera;
    // Start is called before the first frame update
    void Start()
    {
        myprefab = Resources.Load("Ball") as GameObject;
        mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x;
    }   

    // Update is called once per frame
    void Update()
    {
        xpos = Random.Range(xmin, xmax);
        Instantiate(myprefab, new Vector3(xpos, 8f, 0f), Quaternion.identity);
      
    }
}
