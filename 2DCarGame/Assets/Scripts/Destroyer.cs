using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    

    [SerializeField] int scoreValue;
    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.GetComponent<PolygonCollider2D>())
        {
            FindObjectOfType<GameSession>().AddToScore(scoreValue);
        }
        Destroy(otherObject.gameObject);
        
    }

}
