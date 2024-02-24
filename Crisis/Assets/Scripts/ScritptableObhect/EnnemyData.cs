using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnnemyData", menuName = "Ennemy/EnemyData")]
public class EnnemyData : ScriptableObject
{
    public int baseDamage = 10; // Dégâts de base de l'ennemi

    // Méthode pour calculer les dégâts réels infligés par l'ennemi
    public int CalculateDamage()
    {
       
        return baseDamage;
    }
}
