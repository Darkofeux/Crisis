using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int damages = 20;
    // Cette méthode est appelée lorsqu'un autre collider entre en collision avec cet objet
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifier si la collision est avec le joueur
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }
}
