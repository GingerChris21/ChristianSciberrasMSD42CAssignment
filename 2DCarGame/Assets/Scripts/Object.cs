using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] float shotCounter;

    [SerializeField] float minTimeBetweenFiring = 0.5f;

    [SerializeField] float maxTimeBetweenFiring = 1.5f;

    [SerializeField] GameObject objectBulletPrefab;

    [SerializeField] float objectBulletSpeed = 0.5f;

    [SerializeField] GameObject deathVFX;
    [SerializeField] float explosionDuration = 1f;

    private void Start()
    {
        shotCounter = Random.Range(minTimeBetweenFiring, maxTimeBetweenFiring);
    }

    private void Update()
    {
        StartingFire();
    }

    private void StartingFire()
    {
        shotCounter -= Time.deltaTime;

        if (shotCounter <= 0f)
        {
            ObjectFire();
            shotCounter = Random.Range(minTimeBetweenFiring, maxTimeBetweenFiring);
        }
    }

    private void ObjectFire()
    {
        GameObject objectBullet = Instantiate(objectBulletPrefab, transform.position, Quaternion.identity) as GameObject;

        objectBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -objectBulletSpeed);
    }
    private void Defeat()
    {
        Destroy(gameObject);
        GameObject crash_explosion = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(crash_explosion, explosionDuration);
        
    }
}
