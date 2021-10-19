using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtMouse : MonoBehaviour
{
    private GameObject myballPrefab;
    Vector3 mousePosScreen,mousePosWorld;
    bool mouseClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        myballPrefab = Resources.Load("ball") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
        mouseClicked = Input.GetMouseButtonDown(0);
        Debug.Log(mousePosScreen);
        
        if (mouseClicked == true)
        {
            mousePosScreen = Input.mousePosition;
            Debug.Log("Screen units: " + mousePosScreen.ToString());
            mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosScreen);
            Debug.Log("Mouse in world units: " + mousePosWorld.ToString());
            Instantiate(myballPrefab, new Vector3(mousePosWorld.x, mousePosWorld.y, 0f), Quaternion.identity);

        }
    }
}
