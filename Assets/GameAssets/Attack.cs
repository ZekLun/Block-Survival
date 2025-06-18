using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireForce = 20f;
    private float shootTimer = 0;
    public float shootCooldown = 1f;
    [SerializeField] private float time = 1f;
    private bool autoFire = false;
    void Update()
    {
        shootTimer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E))
        {
            autoFire = !autoFire;
        }
        if (autoFire == true)
        {
            Fire();
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                Fire();
            }
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
}
