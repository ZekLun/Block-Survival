using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    static public int Coins = 0;
    static public int HighScore = 0;
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HighScoreText;
    public GameObject PauseScreen;
    private bool menuActive = false;


    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        HighScoreText.text = "Highscore: " + HighScore.ToString();
    }
    private void Update()
    {
        CoinText.text = Coins.ToString();
        if (Coins >= HighScore)
        {
            HighScoreText.text = "Highscore: " + HighScore.ToString();
            HighScore = Coins;
            PlayerPrefs.SetInt("HighScore", Coins);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuActive = !menuActive;
            PauseScreen.SetActive(menuActive);
            Time.timeScale = menuActive ? 0 : 1;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Continue()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1;
        menuActive = false;
    }

}
