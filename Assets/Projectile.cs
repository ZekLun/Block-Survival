using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] private float time = 5f;
    private Weapon weapon;


    private void Start()
    {
        GameObject weaponObject = GameObject.Find("Bow");

        weapon = weaponObject.GetComponent<Weapon>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController enemy = collision.GetComponent<EnemyController>();
        
        if (collision.gameObject.tag != "PlayerProjectile" && collision.gameObject.tag != "Player")
        {
            enemy.TakeDamage(weapon.dmg);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0f)
        {
            timeEnded();
        }

        void timeEnded()
        {
            Destroy(gameObject);
        }
    }
}
