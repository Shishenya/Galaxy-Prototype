using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Ship
{
    public override void Hello()
    {
        Debug.Log("������� ���������� " + gameObject.name + " ������ � ����� � ���");
    }

    public override void Death()
    {
        Debug.Log("DEATH ENEMY");
        Destroy(gameObject);
    }
}
