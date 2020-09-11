using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Session : MonoBehaviour
{
    float timeLeft = GameplayParameters.sessionTime;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player.health = GameplayParameters.playerHealth;
        player.forwardSpeed = GameplayParameters.playerForwardSpeed;
        player.rotationSpeed = GameplayParameters.playerRotationSpeed;
        GameplayParameters.points = 0;
    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }
}
