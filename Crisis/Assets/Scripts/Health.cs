using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private int health = 100;
    [SerializeField] private int max_Health = 100;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Damage(10);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Heal(10);
        }
    }
    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Ne peut pas avoir de degat negatif");
        }
        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Ne peut pas avoir de soin negatif");
        }

        if (health + amount > max_Health)
        {
            this.health = max_Health;
        }
        else
        {
            this.health += amount;
        }
    }

    private void Die()
    {
        Debug.Log("Vous etes mort");
    }
}
