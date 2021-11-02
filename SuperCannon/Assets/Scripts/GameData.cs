using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    static float XMin, XMax, YMin, YMax;
    static Camera gameCamera = Camera.main;
    static Vector3 mousePos = new Vector3();
    public static void GetXMin()
    {
        XMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x ;
    }

    public static void GetXMax()
    {
        XMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
    }

    public static void GetYMin()
    {
        YMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
    }

    public static void GetYMax()
    {
        YMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }

    public static Vector3 GetMouseTarget()
    {
        mousePos = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }

}
