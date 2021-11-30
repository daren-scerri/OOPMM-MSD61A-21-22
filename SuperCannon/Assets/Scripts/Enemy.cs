using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "floor")
            {
            Destroy(this.gameObject);
            }

        if (other.gameObject.name.Contains("Bullet"))
            {
            Destroy(other.gameObject);
            //GameObject.Find("GameManagerHolder").GetComponent<GameManager>().IncreaseScore(5);
            GameManager._instance.IncreaseScore(5);
            Destroy(this.gameObject);
            }

    }



}
