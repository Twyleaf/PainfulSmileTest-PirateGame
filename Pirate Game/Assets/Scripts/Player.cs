using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Ship
{
    Rigidbody2D rb;

    float rotateInput;
    float forwardInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rotateInput = Input.GetAxisRaw("Horizontal");
        forwardInput = Input.GetAxisRaw("Vertical");
        forwardInput = Mathf.Max(forwardInput, 0);
    }

    private void FixedUpdate()
    {

        rb.rotation += -rotateInput * rotationSpeed;

        rb.velocity = (forwardInput * forwardSpeed) * Rotate(Vector2.down, rb.rotation) ;

    }

}
