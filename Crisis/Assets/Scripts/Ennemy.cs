using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemyData; // Référence à l'objet ScriptableObject EnemyData

    // Cette méthode est appelée lorsqu'un autre collider entre en collision avec cet objet
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifier si la collision est avec le joueur
        if (collision.gameObject.CompareTag("Player"))
        {
            // Si c'est le cas, infliger des dégâts au joueur
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                int damage = enemyData.CalculateDamage(); // Calculer les dégâts à partir du ScriptableObject EnemyData
                playerHealth.playerData.TakeDamage(damage);
            }
        }
    }
}
