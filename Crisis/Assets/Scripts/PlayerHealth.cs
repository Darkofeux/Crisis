using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData playerData;

    private void Start()
    {
        playerData.Initialize(); // Initialiser les donn�es du joueur au d�but
    }

    public  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                int damage = enemy.enemyData.CalculateDamage();
                playerData.TakeDamage(damage); // Appliquer les d�g�ts au joueur
            }
        }
    }
}
