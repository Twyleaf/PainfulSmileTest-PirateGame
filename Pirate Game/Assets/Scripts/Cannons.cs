using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannons : MonoBehaviour
{

    public Transform frontalCannon;
    public Transform[] sideCannons;
    public GameObject cannonballPrefab;

    private float time = 0.3f;
    private float timer;

    void Start()
    {
        timer = time;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                ShootFront();
                timer = time;
            }
            if (Input.GetButtonDown("Fire2"))
            {
                ShootSides();
                timer = time;
            }
        }
    }

    private void ShootFront()
    {
        Shoot(frontalCannon);
    }

    private void ShootSides()
    {
        foreach (Transform cannon in sideCannons)
        {
            Shoot(cannon);
        }
    }

    private void Shoot(Transform cannon)
    {
        GameObject CannonballObject = Instantiate(cannonballPrefab, cannon.position, cannon.rotation);
        Cannonball cannonball = CannonballObject.GetComponent<Cannonball>();
        cannonball.damage = GameplayParameters.playerDamage;
    }
}
