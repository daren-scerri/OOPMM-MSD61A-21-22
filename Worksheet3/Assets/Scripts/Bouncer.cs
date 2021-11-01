using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bouncer : MonoBehaviour
{
    
    [SerializeField] int ballhealth = 100;
    Rigidbody2D rb;


    [SerializeField] Text mytext;



    Vector2 otherVelocity = new Vector2(0f, 0f);
  //  [SerializeField] GameObject otherObject;
    
    // Start is called before the first frame update
    void Start()
    {

        

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(400f,200f));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        ballhealth-=10;

        mytext.text = "Health: " + ballhealth.ToString();

        otherVelocity= otherVelocity + new Vector2(50f, 50f);
        Debug.Log(ballhealth);
         Color tmp = GetComponent<SpriteRenderer>().color;
         tmp.a-= 0.1f;
         GetComponent<SpriteRenderer>().color = tmp;
         if (ballhealth<=0)
            {
            mytext.text = "THE BALL IS DEAD";
            Destroy(this.gameObject);
            }
            
    }

}
