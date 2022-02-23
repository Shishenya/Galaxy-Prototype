using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : Shot
{

    const float maxY = 4f;
    const int layerBulletEnemy = 11;

    public override void Update()
    {

        CheckOutScreen();

        if (isReadyShot)
        {
            // Debug.Log("Enemy! Shot!!");
            Fire();
        }

        base.Update();
    }

    public override void Fire()
    {
        GameObject bulletGO = Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0f, 0f, -180f));
        bulletGO.layer = layerBulletEnemy;
        isReadyShot = false;
    }

    public void CheckOutScreen()
    {
        if (transform.position.y > maxY) isReadyShot = false;
    }
}
