using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public InputField playerHealthText;
    public InputField playerDamageText;
    public InputField playerForwardSpeedText;
    public InputField playerRotationSpeedText;

    public InputField enemyHealthText;
    public InputField enemyDamageText;
    public InputField enemyForwardSpeedText;
    public InputField enemyRotationSpeedText;
    public InputField enemySpawnRateText;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }

    public void ShowOptions()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void SaveOptions()
    {
        if(playerHealthText.text!="")
            GameplayParameters.playerHealth = int.Parse(playerHealthText.text);
        if (playerDamageText.text != "")
            GameplayParameters.playerDamage = int.Parse(playerDamageText.text);
        if (playerForwardSpeedText.text != "")
            GameplayParameters.playerForwardSpeed = float.Parse(playerForwardSpeedText.text);
        if (playerRotationSpeedText.text != "")
            GameplayParameters.playerRotationSpeed = float.Parse(playerRotationSpeedText.text);

        if (enemyHealthText.text != "")
            GameplayParameters.enemyHealth = int.Parse(enemyHealthText.text);
        if (enemyDamageText.text != "")
            GameplayParameters.enemyDamage = int.Parse(enemyDamageText.text);
        if (enemyForwardSpeedText.text != "")
            GameplayParameters.enemyForwardSpeed = float.Parse(enemyForwardSpeedText.text);
        if (enemyRotationSpeedText.text != "")
            GameplayParameters.enemyRotationSpeed = float.Parse(enemyRotationSpeedText.text);
        if (enemySpawnRateText.text != "")
            GameplayParameters.enemySpawnRate = float.Parse(enemySpawnRateText.text);

        GameplayParameters.LogParameters();
    }
}
