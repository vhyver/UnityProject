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
            //if (collision.GetComponent<EnemyReceiveDmg>() != null)
            //{
            //    collision.GetComponent<EnemyReceiveDmg>().ReceiveDamage(dmg);
            //}
            Destroy(gameObject);
        }
    }
}
