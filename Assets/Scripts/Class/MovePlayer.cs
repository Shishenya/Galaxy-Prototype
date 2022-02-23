using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MoveShip
{

    private Vector2 _movement;

    void Update()
    {

         _movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    public void FixedUpdate()
    {
        Move(_movement);
    }

}
