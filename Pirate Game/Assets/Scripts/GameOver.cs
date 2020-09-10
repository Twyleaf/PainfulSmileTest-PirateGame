using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TMP_Text pointsText;
        

    void Start()
    {
        //Text sets your text to say this message
        pointsText.text = "Points Earned:" + (GameplayParameters.points);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
