using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollidable : MonoBehaviour
{

    Bullet _selfBullet;

    private void Start()
    {
        _selfBullet = GetComponent<Bullet>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("пуля " + gameObject.name + " столнулась с объектом " + collision.gameObject.name);
        if (collision.gameObject.GetComponent<Health>()!=null)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeDamage(_selfBullet.damage);
            Debug.Log("пуля " + gameObject.name + " столнулась с объектом " + collision.gameObject.name + " и нанесла ему урон " + _selfBullet.damage);
            Destroy(gameObject);
        }
    }

}
