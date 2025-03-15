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
    void Update()
    {
        shootTimer += Time.deltaTime;
        Fire();
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
}
