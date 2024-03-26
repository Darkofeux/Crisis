using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthSytem : MonoBehaviour
{
    public  Health health;
   private new Light light;
    public GameObject lightPrefab;
    public float lightDistance = 10f;
    public float maxLightRange = 20f;
    private bool ligthAttackOn=false;
    void Start()
    {
        health = GetComponent<Health>();
        light = GetComponentInChildren<Light>();

    }
    void Update()
    {
        if (health.Getlife() != light.range)
        {
            UpdateLightRange(); // Mettre à jour la portée de la lumière
        }
        float newLightRange = maxLightRange * (health.Getlife() / (float)health.GetlifeMax());
       
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            AttackLigth();
            ligthAttackOn=true;
            
        }
    } 

    public void AttackLigth() 
    {
        if (ligthAttackOn == false)
        {
            lightPrefab.SetActive(true);
             Vector3 spawnPosition = transform.position + transform.forward * lightDistance;
            spawnPosition.y = 0.44f;
            GameObject newLight = Instantiate(lightPrefab, spawnPosition, Quaternion.identity);
            light.range -= lightDistance;
            health.Damage(10);
        }
    }

    void UpdateLightRange()
    {
        // Calculer la nouvelle portée de la lumière en fonction de la vie du personnage
        float newLightRange = maxLightRange * (health.Getlife() / (float)health.GetlifeMax());

        // Limiter la portée minimale de la lumière à 0
        newLightRange = Mathf.Max(newLightRange, 0f);

        // Définir la nouvelle portée de la lumière
        light.range = newLightRange;
    }
   public  void LigthRecuperation(GameObject LigthClone) 
    {
        ligthAttackOn = false;
        if(ligthAttackOn == false)
        {
            Destroy(LigthClone);
            health.Heal(10);
        }
    }

}