using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannons : MonoBehaviour
{

    public Transform frontalCannon;
    public Transform[] sideCannons;
    public GameObject cannonballPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootFront();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ShootSides();
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
