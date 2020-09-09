using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D body;

    float rotateInput;
    float forwardInput;

    public float forwardSpeed;
    public float rotationSpeed;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rotateInput = Input.GetAxisRaw("Horizontal");
        forwardInput = Input.GetAxisRaw("Vertical");
        forwardInput = Mathf.Max(forwardInput, 0);
    }

    private void FixedUpdate()
    {

        body.rotation += rotateInput * rotationSpeed;

        body.velocity = (forwardInput * forwardSpeed) * Rotate(Vector2.down, body.rotation) ;

    }

    private Vector2 Rotate(Vector2 v, float degrees)
    {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v;
    }
}
