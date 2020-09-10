using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    public float speed = 20.0f;
    public int damage = 1;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.up * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(hitInfo.name);
        Ship ship = collision.gameObject.GetComponent<Ship>();
        if (ship != null)
        {
            ship.TakeDamage(damage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
   
}
