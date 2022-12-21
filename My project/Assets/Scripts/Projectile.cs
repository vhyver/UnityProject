using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float dmg;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name != "Player")
        {
            if(collision.GetComponent<EnemyReceiveDmg>() != null)
            {
                collision.GetComponent<EnemyReceiveDmg>().ReceiveDamage(dmg);
            }
            Destroy(gameObject);
        }
    }
}
