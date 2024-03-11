using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    private GameObject attackArea = default;
    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f; 

   
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject; // On recupere AttackArea qui se trouve dans la hierarchie 
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) // Si on appuie sur O on lance la méthode Attack
        {
            Attack();
        }

        if (attacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }

    private void Attack() // La methode Attack
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}
