using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReceiveDmg : MonoBehaviour
{
    public float health;
    public float maxHealth;
    void Start()
    {
        health = maxHealth;
    }

    public void ReceiveDamage(float dmg)
    {
        health -= dmg;
        CheckDeath();
    }
    private void CheckDeath()
    {
        if(health <= 0) 
        {
            Destroy(gameObject);
        }
    }

    private void CheckOverHeal()
    {
        if(health > maxHealth) 
        {
            health = maxHealth;
        }
    }
}
