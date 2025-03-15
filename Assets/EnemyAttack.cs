using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireForce = 20f;
    [SerializeField] private float shootTimer = 0.5f;
    [SerializeField] private float shootCooldown = 0.25f;
    [SerializeField] private float time = 1f;
    [SerializeField] private enum WeaponType { Melee, Ranged }
    [SerializeField] private WeaponType weaponType;
    [SerializeField] private GameObject Melee;
    [SerializeField] private float atkDuration = 0.5f;
    float atkCooldown;
    bool isAttacking;

    void Update()
    {

        if (weaponType == WeaponType.Ranged)
        {
            shootTimer += Time.deltaTime;
            Fire();
        }
        AttackCooldown();
        if (weaponType == WeaponType.Melee)
        {
            Melee.SetActive(true);
            isAttacking = true;
        }
    }
    public void Fire()
    {
        if (shootTimer > shootCooldown)
        {
            shootTimer = 0;
            GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
            arrow.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
            Destroy(arrow, time);
        }
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
