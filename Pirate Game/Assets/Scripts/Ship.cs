using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public int health = 3;

    public float forwardSpeed;
    public float rotationSpeed;

    public GameObject deathEffect;

    public Sprite damagedSprite;
    public Sprite breakingSprite;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health == 2)
        {
            GetComponent<SpriteRenderer>().sprite = damagedSprite;
        }

        if (health == 1)
        {
            GetComponent<SpriteRenderer>().sprite = breakingSprite;
        }

        if (health <= 0)
        {
            if(gameObject.tag == "Player")
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                GameplayParameters.points++;
                Die();
            }
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    protected Vector2 Rotate(Vector2 v, float degrees)
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
