using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackProjectile : MonoBehaviour
{
    public float dmg;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Enemy")
        {
            if (collision.tag == "Player")
            {
                PlayerStats.stats.ReceiveDamage(dmg);
            }
            Destroy(gameObject);
        }
    }
}
