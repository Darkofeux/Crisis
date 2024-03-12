using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private int health = 100; // Points de vie du joueur
    [SerializeField] private int max_Health = 100; // Points de vie max du joueur
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) // Enleve 10 points de vie au joueur en appuyant sur M
        {
            Damage(10);
        }
        if (Input.GetKeyDown(KeyCode.P)) // Ajoute 10 points de vie au joueur en appuyant sur P
        {
            Heal(10);
        }
    }
   

    public void Damage(int amount)
    {
        if(amount < 0) // Si les dégats infligés sont inférieurs a 0 
        {
            throw new System.ArgumentOutOfRangeException("Ne peut pas avoir de degat negatif"); // Fait apparaitre ce message
        }
        this.health -= amount;

        if (health <= 0) // Si les points de vie tombe a zero ou en dessous
        {
            Die(); // Lanced la méthode Die
        }
    }

    public void Heal(int amount) 
    {
        if (amount < 0) // Si les soins prodigués sont inférieurs a 0 
        {
            throw new System.ArgumentOutOfRangeException("Ne peut pas avoir de soin negatif"); // Fait apparaitre ce message
        }

        if (health + amount > max_Health) // Si la vie depasse la vie max du joueur
        {
            this.health = max_Health; // La bloque au hp max 
        }
        else
        {
            this.health += amount;
        }
    }

    private void Die() // Methode de mort du personnage
    {
        Debug.Log("Vous etes mort"); // Fait apparaitre ce message
    }
}
