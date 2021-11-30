using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    
    static Camera gameCamera = Camera.main;
    static Vector3 mousePos = new Vector3();
    
    private static int _score = 0;


    public static int Score
    {
        set { _score = value; }
        get { return _score; }
    }
    
    
    public static float XMin
    {
        get { return gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x; }
    }

    public static float XMax
    {
        get { return gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x; }
    }


    public static float YMin
    {
        get { return gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; }
    }

    public static float YMax
    {
        get { return gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y; }
    }


    public static Vector3 MousePos
    {
        get { return GetMouseTarget(); }
    }


    private static Vector3 GetMouseTarget()
    {
        mousePos = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }

}
