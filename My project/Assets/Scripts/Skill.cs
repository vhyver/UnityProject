using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public GameObject projectile;
    public float minDmg;
    public float maxDmg;
    public float projectileForce;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject skill =  Instantiate(projectile, transform.position, Quaternion.identity);

            //GetCoords
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 playerPos = transform.position;
            Vector2 direction = (mousePos - playerPos).normalized;

            //Fire
            skill.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            skill.GetComponent<Projectile>().dmg = Random.Range(minDmg, maxDmg);
        }
    }
}
