using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollidable : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>()!=null)
        {
            PlayerShip playerShip = GetComponent<PlayerShip>();
            playerShip.Death();

        }
    }

}
