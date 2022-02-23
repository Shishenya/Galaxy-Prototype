using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : Ship
{

    public override void Hello()
    {
        Debug.Log("Привет. Корабль игрока " + gameObject.name + " создан и готов к бою");
    }

    public override void Death()
    {
        Debug.Log("END GAME!");
        UIPlayer uiPlayer = GetComponent<UIPlayer>();
        uiPlayer.SwowEndGamePanel();
    }

}
