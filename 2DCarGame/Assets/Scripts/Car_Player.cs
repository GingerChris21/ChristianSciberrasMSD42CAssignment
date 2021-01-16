using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Player : MonoBehaviour
{

    [SerializeField] float padding = 0.7f;
    [SerializeField] float moveSpeed = 5f;

    [SerializeField] float health = 50f;

    [SerializeField] AudioClip playerHitSound;

    float xMin, xMax, yMin, yMax;
    // Start is called before the first frame update
    void Start()
    {
        SetUpMoveBoundaries();
    }

    // Update is called once per frame
    void Update()
    {
        Move_car();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        DamageDealer dmgDealer = collision.gameObject.GetComponent<DamageDealer>();

        
        if (!dmgDealer) 
        {
            return;
        }

        ProcessHit(dmgDealer);
        AudioSource.PlayClipAtPoint(playerHitSound, Camera.main.transform.position);

    }

    private void ProcessHit(DamageDealer dmgDealer)
    {
        health -= dmgDealer.GetDmg();

        dmgDealer.Contact();

        if (health <= 0)
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        Destroy(gameObject);
    }

    private void SetUpMoveBoundaries()
    {

        Camera gameCamera = Camera.main;


        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;


        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }

    private void Move_car()
    {
        //deltaX is updated with the movment in the x-axis (left and right)
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //newXPos = current x-pos of Player
        //+ diffrence in X by keyboard Input
        var newXPos = transform.position.x + deltaX;
        //clamps the newXPos between xMin and xMax
        newXPos = Mathf.Clamp(newXPos, xMin, xMax);

        this.transform.position = new Vector2(newXPos, transform.position.y);

    }

}
