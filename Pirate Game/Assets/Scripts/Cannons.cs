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
        Instantiate(cannonballPrefab, frontalCannon.position, frontalCannon.rotation);
    }

    private void ShootSides()
    {
        foreach (Transform cannon in sideCannons)
        {
            Instantiate(cannonballPrefab, cannon.position, cannon.rotation);
        }
    }
}
