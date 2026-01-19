using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    int scene = 0;
    public TextMeshProUGUI highscoreText;
    private int highscore;
    private WaveSpawner wavespawner;

    
    private void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        wavespawner = FindAnyObjectByType<WaveSpawner>();
        highscore = PlayerPrefs.GetInt("highscore", 0);


        if (currentScene == "EasyGame")
        {
            scene = 1;
        }
        else if (currentScene == "HardGame")
        {
            scene = 2;
        }
    }
    private void Update()
    {
        if (wavespawner.currentWave > highscore)
        {
            highscore = wavespawner.currentWave;
            PlayerPrefs.SetInt("highscore", highscore);
            Debug.Log("Highscore changed");
        }
        highscoreText.text = "Highscore: " + highscore.ToString();
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
