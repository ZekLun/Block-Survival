using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameOverScript : MonoBehaviour
{
    int scene = 0;
    
    private void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "EasyGame")
        {
            scene = 1;
        }
        else if (currentScene == "HardGame")
        {
            scene = 2;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(scene);
        UIScript.Coins = 0;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        UIScript.Coins = 0;
    }
}
