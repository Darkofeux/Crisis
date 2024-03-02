using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData playerData;
    public Health health;

    private void Start()
    {
        playerData.Initialize(); // Initialiser les données du joueur au début
        health = GetComponent<Health>();
    }


    public  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
               
                health.TakeDamage(enemy.damages); // Appliquer les dégâts au joueur
            }
        }
    }
}
