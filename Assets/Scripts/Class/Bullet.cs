using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, ICheckOutOfScreen
{
    private Rigidbody2D _rb;
    private Transform _selfTransform;
    private Vector2 _direction;

    [SerializeField] List<Sprite> spriteBullet = new List<Sprite>();
    public int currentSprite;
    public float speedBullet;
    public int damage;

    public WhoIsShot shotParrent;

    const float maxY = 6f;
    const float minY = -6f;

    public void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _selfTransform = GetComponent<Transform>();
        _direction = new Vector2(0, 1);

        if (transform.rotation.z <= -1)
        {
            _direction = new Vector2(0, -1);
        }

    }

    private void Update()
    {
        if (isOutOfScreen())
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        _rb.velocity = _direction * speedBullet;
    }

    public bool isOutOfScreen()
    {
        if (_selfTransform.position.y > maxY || _selfTransform.position.y < minY)
        {
            return true;
        }

        return false;
    }
}
