using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{

    private Ship _selfShip;
    private Rigidbody2D _rb;

    public virtual void Start()
    {
        _selfShip = GetComponent<Ship>();
        _rb = _selfShip.RB;
    }

    public void Move(Vector2 direction)
    {
        Vector3 _direction = new Vector3(direction.x, direction.y, 0);
        _rb.MovePosition(transform.position + (_direction * _selfShip.speedShip * Time.deltaTime));
    }


}
