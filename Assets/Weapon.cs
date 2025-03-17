using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float dmg = 1f;
    public enum WeaponType { Melee, Ranged }
    public WeaponType weaponType;
    public GameObject weaponOwner;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController enemy = collision.GetComponent<EnemyController>();
        PlayerController player = collision.GetComponent<PlayerController>();

        if (collision.gameObject.CompareTag("Player"))
        {
            if (player != null)
                player.TakeDamage(dmg);

            if (weaponType == WeaponType.Ranged)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (weaponOwner != null && weaponOwner.CompareTag("Enemy"))
            {
                return;
            }
            if (enemy != null)
                enemy.TakeDamage(dmg);

            if (weaponType == WeaponType.Ranged)
            {
                Destroy(gameObject);
            }

        }

    }
}
