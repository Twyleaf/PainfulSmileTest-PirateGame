using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Enemy
{

    public Transform frontalCannon;
    public GameObject cannonballPrefab;

    bool inRange = false;

    //public Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        InvokeRepeating("Shoot", 2.0f, 0.3f);
    }

    void Shoot()
    {
        if (inRange)
        {
            Instantiate(cannonballPrefab, frontalCannon.position, frontalCannon.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        RotateToPlayer();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.name == "Player") inRange = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.name == "Player") inRange = false;
    }
}
