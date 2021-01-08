using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int dmg = 1;

    public int GetDmg()
    {
        return dmg;
    }

    public void Contact()
    {
        Destroy(gameObject);
    }

}
