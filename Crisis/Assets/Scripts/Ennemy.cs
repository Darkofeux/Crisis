using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemyData; // R�f�rence � l'objet ScriptableObject EnemyData

    // Cette m�thode est appel�e lorsqu'un autre collider entre en collision avec cet objet
    private void OnCollisionEnter(Collision collision)
    {
        // V�rifier si la collision est avec le joueur
        if (collision.gameObject.CompareTag("Player"))
        {
            // Si c'est le cas, infliger des d�g�ts au joueur
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                int damage = enemyData.CalculateDamage(); // Calculer les d�g�ts � partir du ScriptableObject EnemyData
                playerHealth.playerData.TakeDamage(damage);
            }
        }
    }
}
