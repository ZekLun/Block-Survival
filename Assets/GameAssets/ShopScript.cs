using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    private int hpCost, atkspdCost, dmgCost, speedCost = 1;
    PlayerController playerController;
    Attack attack;
    public Weapon weapon;
    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        attack = playerController.GetComponent<Attack>();
        hpCost = 15;
        dmgCost = 30;
        atkspdCost = 10;
        speedCost = 20;
    }
    public void IncreaseHealth()
    {
        if (TryPurchase(ref hpCost, 20))
        {
            playerController.maxHealth += 10;
            Debug.Log("Health Increased to " + playerController.maxHealth);
        }
    }
    public void IncreaseDmg()
    {
        if (TryPurchase(ref dmgCost, 35))
        {
            weapon.dmg += 1;
            Debug.Log("Damage Increased to ");
        }
    }

    public void IncreaseAtkSpd()
    {
        if (TryPurchase(ref atkspdCost, 20))
        {
            attack.shootCooldown = Mathf.Max(0.05f, attack.shootCooldown - 0.08f);
            Debug.Log("Attack Speed Increased to " + attack.shootCooldown);
        }
    }
    public void IncreaseSpeed()
    {
        if (TryPurchase(ref speedCost, 25))
        {
            playerController.movementSpeed += 1;
            Debug.Log("MovementSpeed Increased to " + playerController.movementSpeed);
        }
    }

    bool TryPurchase(ref int cost, int costIncrement)
    {
        if (UIScript.Coins >= cost)
        {
            UIScript.Coins -= cost;
            cost += costIncrement;
            return true;
        }
        else
        {
            Debug.Log("Insufficient Funds");
            return false;
        }
    }


}
