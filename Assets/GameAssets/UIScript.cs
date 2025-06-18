using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    static public int Coins = 0;

    public TextMeshProUGUI CoinText;
    public GameObject PauseScreen;
    public TextMeshProUGUI WaveText;
    private WaveSpawner waveSpawner;


    private bool menuActive = false;


    private void Start()
    {
        waveSpawner = FindAnyObjectByType<WaveSpawner>();
    }
    private void Update()
    {
        CoinText.text = "Kubix: " + Coins.ToString();
        WaveText.text = "Wave: " + waveSpawner.currentWave.ToString();

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
        Time.timeScale = 1;
        menuActive = false;
    }

    public void Continue()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1;
        menuActive = false;
    }

}
