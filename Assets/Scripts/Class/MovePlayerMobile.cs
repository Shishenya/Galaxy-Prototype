using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerMobile : MoveShip
{
    [SerializeField] private FixedJoystick fixedJoystick;
    private Vector2 _movement;

    void Update()
    {

        _movement = new Vector2(fixedJoystick.Horizontal, fixedJoystick.Vertical);
    }

    public void FixedUpdate()
    {
        Move(_movement);
    }
}
