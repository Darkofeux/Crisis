using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
   
    public float interactionRange = 3f; // Port�e de l'interaction
    public string interactionTag = "interaction";
    private LigthSytem LigthSytem;
    private bool canInteract = false; // Indique si le joueur peut interagir avec un objet
    void Start()
    {

    }

    void Update()
    {
        if (canInteract&& Input.GetKeyDown(KeyCode.E))
        {
            InteractionLigth();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // V�rifier si le collider en contact a le tag "interaction"
        if (other.CompareTag(interactionTag))
        {
           canInteract=true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // D�sactiver la possibilit� d'interagir lorsque le joueur cesse d'�tre en contact avec l'objet
        canInteract = false;
    }

   
    public void InteractionLigth()
    {
        LigthSytem.LigthRecuperation();
        Debug.LogError("methode lance");
    } 
}


