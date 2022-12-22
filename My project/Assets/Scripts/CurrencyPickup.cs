using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : MonoBehaviour
{
    public enum Resource { COIN, MANACRYSTAL };

    public int currencyValue;
    public Resource currentResource;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (currentResource == Resource.COIN)
                PlayerStats.stats.coins += currencyValue;
            else if (currentResource == Resource.MANACRYSTAL)
                PlayerStats.stats.manaCrystals += currencyValue;

            PlayerStats.stats.UpdateCurrency(currencyValue);
            Destroy(gameObject);
        }
    }
}
