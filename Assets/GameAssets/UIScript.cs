using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    static public int Coins = 0;
    static public int HighScore = 0;
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HighScoreText;


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
    }

}
