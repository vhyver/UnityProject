using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : MonoBehaviour
{
    public GameObject projectile;
    public Transform player;
    public float minDmg;
    public float maxDmg;
    public float projectileForce;
    public float cooldown;

    void Start()
    {
        StartCoroutine(ShootPlayer());
    }
    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if (player != null)
        {
            GameObject arrow = Instantiate(projectile, transform.position, Quaternion.identity);

            //Coords
            Vector2 myPos = transform.position;
            Vector2 playerPos = player.position;
            Vector2 direction = (playerPos - myPos).normalized;

            //Fire
            arrow.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            arrow.GetComponent<EnemyAttackProjectile>().dmg = Random.Range(minDmg, maxDmg);

            StartCoroutine(ShootPlayer());
        }
    }
}
