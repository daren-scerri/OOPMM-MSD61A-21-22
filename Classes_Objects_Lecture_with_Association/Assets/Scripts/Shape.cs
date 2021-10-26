using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape
{
    public float xpos, ypos, xspeed, yspeed;

    // Start is called before the first frame update

    public Shape(float _xpos, float _ypos, float _xspeed, float _yspeed)
    {
        xpos = _xpos;
        ypos = _ypos;
        xspeed = _xspeed;
        yspeed = _yspeed;
    }

    public void MoveLeft(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(-xspeed, 0);
    }

    public void MoveRight(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(xspeed, 0);
    }

    public void MoveUp(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(0, yspeed);
    }

    public void MoveDown(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(0, -yspeed);
    }

    public void ResetPosition(Rigidbody2D rb)
    {
        rb.position = new Vector2(xpos, ypos);

    }

}
