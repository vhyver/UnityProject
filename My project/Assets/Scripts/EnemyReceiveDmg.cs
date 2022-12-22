using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyReceiveDmg : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthBar;
    public Slider healthBarSlider;
    public GameObject loot;
    void Start()
    {
        health = maxHealth;
    }

    public void ReceiveDamage(float dmg)
    {
        healthBar.SetActive(true);
        health -= dmg;
        CheckDeath();
        healthBarSlider.value = VisualiseHealth();
    }
    private void CheckDeath()
    {
        if(health <= 0) 
        {
            Destroy(gameObject);
            Instantiate(loot, transform.position, Quaternion.identity);
        }
    }

    //heal mechanics?
    private void CheckOverHeal()
    {
        if(health > maxHealth) 
        {
            health = maxHealth;
        }
    }

    private float VisualiseHealth()
    {
        return health / maxHealth;
    }
}
