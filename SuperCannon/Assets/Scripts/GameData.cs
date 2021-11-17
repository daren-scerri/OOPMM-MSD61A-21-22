using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    static float XMin, XMax, YMin, YMax;
    static Camera gameCamera = Camera.main;
    static Vector3 mousePos = new Vector3();
    public static float GetXMin()
    {
        XMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x ;
        Debug.Log("XMin: " + XMin.ToString());
        return XMin;
    }

    public static float GetXMax()
    {
        XMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        Debug.Log("XMax: " + XMax.ToString());
        return XMax;
    }

    public static float GetYMin()
    {
        YMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        Debug.Log("YMin: " + YMin.ToString());
        return YMin;
    }

    public static float GetYMax()
    {
        YMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        Debug.Log("YMax: " + YMax.ToString());
        return YMax;
    }

    public static Vector3 GetMouseTarget()
    {
        mousePos = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }

}
