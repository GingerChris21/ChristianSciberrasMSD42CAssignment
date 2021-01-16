using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2 : MonoBehaviour
{
    [SerializeField] float health = 1f;

    [SerializeField] GameObject deathVFX;
    [SerializeField] float explosionDuration = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        DamageDealer dmgDealer = collision.gameObject.GetComponent<DamageDealer>();

        if (!dmgDealer) 
        {
            return;
        }

        CalculateHit(dmgDealer);

    }
    
    private void CalculateHit(DamageDealer dmgDealer)
    {
        health -= dmgDealer.GetDmg();


        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        GameObject crash_explosion = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(crash_explosion, explosionDuration);
    }
}
