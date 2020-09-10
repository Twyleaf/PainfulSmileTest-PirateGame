using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session : MonoBehaviour
{
    public static int points = 0;
    float timeLeft = 120.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            //GameOver();
            Debug.Log("Foi");
        }
        
    }
}
