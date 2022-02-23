using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MoveShip
{

    private Vector2 _targetPoint;
    private Vector2 _startPoint;

    [SerializeField] private float _cooldawnChangeDirection = 2.5f;
    [SerializeField] private float _cooldawnChangeY = 3.5f;
    private float _timerCooldawnChangeDirection;
    private float _timerCooldawnChangeY;

    public override void Start()
    {
        base.Start();
        _startPoint = transform.position;
        NewTargetPoint();
        _timerCooldawnChangeDirection = _cooldawnChangeDirection;
        _timerCooldawnChangeY = _cooldawnChangeY;
    }

    private void NewTargetPoint()
    {
        int randX = Random.Range(-3, 3);
        _targetPoint = new Vector2(randX, transform.position.y);
    }

    private void FixedUpdate()
    {

        // Смена позиции по X по кулдауну
        ChangeDirectionByCooldawn();

        // Смена позиции, если достигли точки
        ChangeDirectionByDistance();

        // Смена позиции по Y
        ChangeY();

        Vector3 _direction = new Vector3(_targetPoint.x - _startPoint.x, _targetPoint.y - _startPoint.y, 0);
        _direction = _direction.normalized;

        Move(_direction);
    }

    private void ChangeDirectionByCooldawn()
    {
        if (_timerCooldawnChangeDirection <= 0)
        {
            _timerCooldawnChangeDirection = _cooldawnChangeDirection;
            NewTargetPoint();
            _startPoint = transform.position;
            // Debug.Log("Противник " + gameObject.name + " получил нвоые кооординаты " + _targetPoint);
        }
        else
        {
            _timerCooldawnChangeDirection -= Time.deltaTime;
        }
    }

    private void ChangeDirectionByDistance()
    {
        if (Vector3.Distance(_startPoint, _targetPoint) < 0.1f)
        {
            NewTargetPoint();
        }
    }

    private void ChangeY()
    {
        if (_timerCooldawnChangeY <= 0)
        {
            _timerCooldawnChangeY = _cooldawnChangeY;
            _targetPoint.y -= 1;
        }
        else
        {
            _timerCooldawnChangeY -= Time.deltaTime;
        }
    }

}
