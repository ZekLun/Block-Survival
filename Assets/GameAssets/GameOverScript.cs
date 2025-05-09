using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    int scene = 0;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.GetActiveScene().buildIndex + 1)
        {
            scene += 1;
        }
        else if (SceneManager.GetActiveScene().buildIndex == SceneManager.GetActiveScene().buildIndex + 2)
        {
            scene += 2;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + scene);
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
