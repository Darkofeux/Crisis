using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData playerData;

    private void Start()
    {
        playerData.Initialize(); // Initialiser les données du joueur au début
    }

    public  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                int damage = enemy.enemyData.CalculateDamage();
                playerData.TakeDamage(damage); // Appliquer les dégâts au joueur
            }
        }
    }
}
