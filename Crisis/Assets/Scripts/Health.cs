using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

   
    [ SerializeField]
    private int life;
    [ SerializeField ]
    private int lifeMax;

    public int GetlifeMax() 
    {
        return lifeMax;
    }
     public int Getlife() 
    {
        return life;
    }
    public void TakeDamage(int damage)
    {
        if (life > damage)
        {
            life -= damage;
        }
        else 
        {
            life = 0;
            GameManager.GetInstance().IsDying();
        }
        
    }
    public void Heal(int value) 
    {
        if(life+value>lifeMax) 
        {
            life = lifeMax;
        }
        else  
        {
            life += value;
        }
    }

}
