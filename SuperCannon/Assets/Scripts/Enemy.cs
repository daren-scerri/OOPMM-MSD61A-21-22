using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    ITakeDamage damageable;

    [SerializeField] int starthealth;
    private void Start()
    {
        damageable = GetComponent<ITakeDamage>();
        damageable.health = starthealth;
    }
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
            
            damageable.TakeDamage(1);
            }

    }



}
