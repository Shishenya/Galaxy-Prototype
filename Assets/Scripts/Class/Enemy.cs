using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Ship
{
    public override void Hello()
    {
        Debug.Log(" орабль противника " + gameObject.name + " создан и готов к бою");
    }

    public override void Death()
    {
        Debug.Log("DEATH ENEMY");
        Destroy(gameObject);
    }
}
