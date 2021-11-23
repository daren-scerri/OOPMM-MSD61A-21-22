using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float speed = 5f;
    Vector2 direction;

    protected virtual void Start()
    {
        Vector3 mousepos = GameData.GetMouseTarget();

        //ADD CODE HERE TO DECIDE VELOCITY BASED ON MOUSE POSITION

        direction = mousepos - this.transform.position;
        direction.Normalize();
        Vector2 newvelocity = direction * speed;

        GetComponent<Rigidbody2D>().velocity = newvelocity;
    }
    protected virtual void Update()
    {
        if (this.gameObject.transform.position.y > (GameData.GetYMax() + 1)) Destroy(this.gameObject);
        if (this.gameObject.transform.position.y < (GameData.GetYMin() - 1)) Destroy(this.gameObject);
        if (this.gameObject.transform.position.x > (GameData.GetXMax() + 1)) Destroy(this.gameObject);
        if (this.gameObject.transform.position.x < (GameData.XMin - 1)) Destroy(this.gameObject);
    }
}

    // Update is called once per frame
