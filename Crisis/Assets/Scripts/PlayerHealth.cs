using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData playerData;
    public Health health;

    private void Start()
    {
        playerData.Initialize(); // Initialiser les donn�es du joueur au d�but
        health = GetComponent<Health>();
    }


    public  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
               
                health.TakeDamage(enemy.damages); // Appliquer les d�g�ts au joueur
            }
        }
    }
}
