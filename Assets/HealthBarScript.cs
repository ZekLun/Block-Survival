using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class HealthBarScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Image healthbarfill;
    private float playerMaxHealth;
    private float playerCurrentHealth;

    private void Start()
    {
        playerMaxHealth = GetComponent<PlayerController>().maxHealth;
        playerCurrentHealth = GetComponent<PlayerController>().health;
    }

    private void Update()
    {
        healthbarfill.fillAmount = playerCurrentHealth / playerMaxHealth;
    }
}
