using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    private Rigidbody2D _rb;
    private Transform _selfTransform;

    public List<Sprite> listSprite = new List<Sprite>();
    public int currentSprite;

    public float speedShip;

    public Health selfHealth;

    public Rigidbody2D RB { get=> _rb; }

    public virtual void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _selfTransform = GetComponent<Transform>();
        GetComponent<SpriteRenderer>().sprite = listSprite[0];
        Hello();

        if (GetComponent<Health>()!=null)
        {
            selfHealth = GetComponent<Health>();
        }

    }

    public void ChangeSprite(int newNumberSprite)
    {
        GetComponent<SpriteRenderer>().sprite = listSprite[newNumberSprite];
        currentSprite = newNumberSprite;
    }

    public virtual void Hello()
    {
        Debug.Log("Привет. Корабль (базовый) " + gameObject.name + " создан и готов к бою");
    }

    public virtual void Death()
    {
        Debug.Log("Death base ship !");
    }

}
