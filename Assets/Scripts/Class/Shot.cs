using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float cooldawnShot;
    private float _timerCooldawnShot;
    public bool isReadyShot;

    public void Start()
    {
        _timerCooldawnShot = cooldawnShot;
        isReadyShot = true;
    }

    public virtual void Fire()
    {
        if (isReadyShot)
        {
            GameObject bulletGO = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            isReadyShot = false;
        }
    }

    public virtual void Update()
    {
        TimerCooldawn();
    }

    public void TimerCooldawn()
    {
        if (!isReadyShot)
        {
            _timerCooldawnShot -= Time.deltaTime;
            if (_timerCooldawnShot <= 0)
            {
                isReadyShot = true;
                _timerCooldawnShot = cooldawnShot;
            }
        }
    }

}
