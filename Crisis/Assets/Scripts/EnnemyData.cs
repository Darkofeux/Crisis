using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnnemyData", menuName = "Ennemy/EnemyData")]
public class EnemyData : ScriptableObject
{
    public int maxHealth = 100; // Santé maximale de l'ennemi
    public int Damage = 10; // Dégâts de base de l'ennemi

    // Méthode pour calculer les dégâts réels infligés par l'ennemi
    public int CalculateDamage()
    {
        
        return Damage;
    }
}
