using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //attaching this class (script) to a prefab will create a c# instance (object) of the class Ball 



    Color32 ballcolor;
    // Start is called before the first frame update
    void Start()
    {
        ballcolor = new Color32((byte)Random.Range(0, 255), 
                                        (byte)Random.Range(0, 255), 
                                        (byte)Random.Range(0, 255),255);
        Debug.Log(ballcolor.ToString());
        this.GetComponent<SpriteRenderer>().color= ballcolor;
    }



}
