using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats stats; 
    public GameObject player;
    public float health;
    public float maxHealth;

    void Awake()
    {
        if(stats != null)
            Destroy(stats);
        else
            stats = this;

        DontDestroyOnLoad(this);
    }
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
        if (health <= 0)
        {
            Destroy(player);
        }
    }

    public void HealCharacter(float amount)
    {
        health += amount;
        CheckOverHeal();
    }
    private void CheckOverHeal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
