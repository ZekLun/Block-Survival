using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemyAttack : MonoBehaviour
{
    [SerializeField] private enum WeaponType { Melee, Ranged }
    [SerializeField] private WeaponType weaponType;
    [SerializeField] private GameObject Melee;
    [SerializeField] private float atkDuration = 0.5f;
    float atkCooldown;

    void Update()
    {
        AttackCooldown();
        Melee.SetActive(true);
    }

    public void AttackCooldown()
    {
        atkCooldown += Time.deltaTime;
        if (atkCooldown >= atkDuration)
        {
            atkCooldown = 0;
            Melee.SetActive(false);
        }

    }
}
