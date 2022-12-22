using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats stats; 
    public GameObject player;
    public TextMeshProUGUI healthText;
    public Slider healthbarSlider;
    public TextMeshProUGUI coinsText;

    public float health;
    public float maxHealth;
    public int coins;
    public int manaCrystals;

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
        coins = 0;
        VisualiseHealth();
    }

    public void ReceiveDamage(float dmg)
    {
        health -= dmg;
        CheckDeath();
        VisualiseHealth();
    }
    private void CheckDeath()
    {
        if (health <= 0)
        {
            health = 0;
            Destroy(player);
        }
    }

    public void HealCharacter(float amount)
    {
        health += amount;
        CheckOverHeal();
        VisualiseHealth();
    }
    private void CheckOverHeal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    private float VisualiseHealthBar()
    {
        return health / maxHealth;
    }
    private void VisualiseHealth()
    {
        healthbarSlider.value = VisualiseHealthBar();
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxHealth).ToString();
    }
    public void UpdateCurrency(int value)
    {
        coinsText.text = Mathf.Ceil(value).ToString();
    }
}
