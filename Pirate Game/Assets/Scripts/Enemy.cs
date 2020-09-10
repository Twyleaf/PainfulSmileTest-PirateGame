using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Ship
{
    public Rigidbody2D rb;
    protected Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateToPlayer();
    }

    protected void RotateToPlayer()
    {
        Vector3 vectorToTarget = playerTransform.position - transform.position;
        float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg) + 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed);
    }
}
