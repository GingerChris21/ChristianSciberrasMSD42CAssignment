using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int dmg = 1;
    [SerializeField] GameObject deathVFX;
    [SerializeField] float explosionDuration = 1f;
    public int GetDmg()
    {
        return dmg;
    }

    public void Contact()
    {
        Destroy(gameObject);
    }

}
