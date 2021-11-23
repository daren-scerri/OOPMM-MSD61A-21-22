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
            GameData.Score++;
            Debug.Log("Score : " + GameData.Score.ToString());
            Destroy(this.gameObject);
            }

    }



}
