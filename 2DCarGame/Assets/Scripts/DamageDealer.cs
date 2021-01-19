using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int dmg = 100;
    [SerializeField] GameObject deathVFX;
    [SerializeField] float explosionDuration = 1f;
    public int GetDmg()
    {
        return dmg;
    }

    public void Contact()
    {
        Destroy(gameObject);
        GameObject crash_explosion = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(crash_explosion, explosionDuration);
    }

}
