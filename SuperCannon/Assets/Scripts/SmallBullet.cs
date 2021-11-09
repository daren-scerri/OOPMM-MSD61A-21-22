using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

        Vector3 mousepos = GameData.GetMouseTarget();

        //ADD CODE HERE TO DECIDE VELOCITY BASED ON MOUSE POSITION

        Vector2 direction = mousepos - this.transform.position;
        direction.Normalize();
        Vector2 newvelocity =  direction * speed;

        GetComponent<Rigidbody2D>().velocity = newvelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
