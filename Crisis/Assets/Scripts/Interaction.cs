using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

   public  LigthSytem LigthSytem;
    private bool isInRange = false;
    [SerializeField] private LayerMask interactionLayer;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) )
        {
            Collider[] hit = Physics.OverlapSphere(transform.position + Vector3.up, 2f, interactionLayer);
            if (hit.Length > 0)
            {
                //Light interactedLight = hit[0].GetComponent<Light>();

                //if (interactedLight != null)
                {
                    InteractionLigth(hit[0].gameObject);

                }

            }
        }
    }

    public void InteractionLigth(GameObject LigthClone)
    {
        //Debug.Log("Touche E enfoncée et Interaction détectée :" + interactedLight);
        LigthSytem.LigthRecuperation(LigthClone);
    }
}


