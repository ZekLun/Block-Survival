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
    private bool menuActive = false;

    private void Update()
    {
        CoinText.text = "Kubix: " + Coins.ToString();

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
