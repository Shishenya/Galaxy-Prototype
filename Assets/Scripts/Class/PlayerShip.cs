using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : Ship
{

    public override void Hello()
    {
        Debug.Log("������. ������� ������ " + gameObject.name + " ������ � ����� � ���");
    }

    public override void Death()
    {
        Debug.Log("END GAME!");
        UIPlayer uiPlayer = GetComponent<UIPlayer>();
        uiPlayer.SwowEndGamePanel();
    }

}
