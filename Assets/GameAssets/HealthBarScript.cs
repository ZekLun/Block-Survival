using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Image healthbarfill;
    private PlayerController playerController;
    public TextMeshProUGUI healthText;

    private void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (playerController != null)
        {
            UpdateHealthBar(playerController.health, playerController.maxHealth);
        }
        else
        {
            healthbarfill.fillAmount = 0;
        }
        healthText.text = $"{playerController.health}/{playerController.maxHealth}";
    }

    private void UpdateHealthBar(float currentHealth, float maxHealth)
    {
        healthbarfill.fillAmount = currentHealth / maxHealth;
    }
}
