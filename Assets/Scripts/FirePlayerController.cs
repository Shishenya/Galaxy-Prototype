using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayerController : Shot
{
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isReadyShot)
        {
            Fire();
            //GameObject selfBullet = this.gameObject;
            //Bullet bullet = selfBullet.GetComponent<Bullet>();
            //bullet.shotParrent = WhoIsShot.Player;
        }

        base.Update();

    }
}
