using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnnemyData", menuName = "Ennemy/EnemyData")]
public class EnnemyData : ScriptableObject
{
    public int baseDamage = 10; // D�g�ts de base de l'ennemi

    // M�thode pour calculer les d�g�ts r�els inflig�s par l'ennemi
    public int CalculateDamage()
    {
       
        return baseDamage;
    }
}
