using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        CheckUpdatePlayerHP();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        CheckDeathShip();
        CheckUpdatePlayerHP();

    }

    public void CheckDeathShip()
    {
        if (currentHealth <= 0)
        {
            
            if (GetComponent<Ship>() != null)
            {
                Ship selfShip;
                selfShip = GetComponent<Ship>();
                selfShip.Death();
            }

            CheckDeathEnemy();

        }
    }

    public void CheckUpdatePlayerHP()
    {
        if (currentHealth >= 0)
        {

            if (GetComponent<PlayerShip>() != null)
            {
                UIPlayer uiPlayer = GetComponent<UIPlayer>();
                uiPlayer.UpdateHP(currentHealth);

            }
        }
    }

    public void CheckDeathEnemy()
    {
        if (GetComponent<Enemy>()!=null)
        {
            UiDestroyCount uiDestroyCount = GetComponent<UiDestroyCount>();
            uiDestroyCount.UpdateCount();
        }
    }

}
