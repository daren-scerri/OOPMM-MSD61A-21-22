using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    Shape mycircleshape = new Shape(0f, -3f, 2f, 1f);
    Rigidbody2D circleRB;
    // Start is called before the first frame update
    void Start()
    {
        circleRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) mycircleshape.MoveUp(circleRB);
        if (Input.GetKey(KeyCode.DownArrow)) mycircleshape.MoveDown(circleRB);
        if (Input.GetKey(KeyCode.Space)) mycircleshape.ResetPosition(circleRB);
    }


}
