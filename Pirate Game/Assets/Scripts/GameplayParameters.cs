using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameplayParameters
{
    public static int playerHealth = 3;
    public static int playerDamage = 1;
    public static float playerForwardSpeed = 5f;
    public static float playerRotationSpeed = 5f;

    public static int enemyHealth = 3;
    public static int enemyDamage = 1;
    public static float enemyForwardSpeed = 3f;
    public static float enemyRotationSpeed = 5f;
    public static float enemySpawnRate = 1.2f;

    public static float sessionTime = 120f;

    public static int points = 0;

    public static void LogParameters()
    {
        Debug.Log("Player HP:"+playerHealth+'\n'+ "Player Damage:" + playerDamage + '\n' + "Player Forward Speed:" +
            playerForwardSpeed + '\n' + "Player Rotation Speed:" + playerRotationSpeed + '\n' + 
            "Enemy HP:" + enemyHealth + '\n' + "Enemy Damage:" + enemyDamage + '\n' + "Enemy Forward Speed:" + 
            enemyForwardSpeed + '\n' + "Enemy Rotation Speed:" + enemyRotationSpeed + '\n' + "Enemy Spawn Rate:" + enemySpawnRate + '\n');
    }
}