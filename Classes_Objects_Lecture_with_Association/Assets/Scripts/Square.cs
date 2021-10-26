using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    Shape mysquareshape = new Shape(0f, 3f, 1f, 2f);
    Rigidbody2D myrb;
    // Start is called before the first frame update
    void Start()
    {
        myrb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) mysquareshape.MoveUp(myrb);
        if (Input.GetKey(KeyCode.S)) mysquareshape.MoveDown(myrb);
        if (Input.GetKey(KeyCode.LeftAlt)) mysquareshape.ResetPosition(myrb);
    }



}