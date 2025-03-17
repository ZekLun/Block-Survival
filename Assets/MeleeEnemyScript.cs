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
    bool isAttacking;

    void Update()
    {
        AttackCooldown();
        Melee.SetActive(true);
        isAttacking = true;
    }

    public void AttackCooldown()
    {
        atkCooldown += Time.deltaTime;
        if (atkCooldown >= atkDuration)
        {
            atkCooldown = 0;
            isAttacking = false;
            Melee.SetActive(false);
        }

    }
}
