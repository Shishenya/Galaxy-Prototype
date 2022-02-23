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
        Debug.Log("���� " + gameObject.name + " ���������� � �������� " + collision.gameObject.name);
        if (collision.gameObject.GetComponent<Health>()!=null)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeDamage(_selfBullet.damage);
            Debug.Log("���� " + gameObject.name + " ���������� � �������� " + collision.gameObject.name + " � ������� ��� ���� " + _selfBullet.damage);
            Destroy(gameObject);
        }
    }

}
