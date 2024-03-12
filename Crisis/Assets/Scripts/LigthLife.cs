using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthLife : MonoBehaviour
{
    private Health health;
    private new Light light;
    private float originalLightRange;
    void Start()
    {
        health = GetComponent<Health>();
        light = GetComponent<Light>();
        originalLightRange = light.range;

    }
    void Update()
    {


        //if (health.Die())
        //{
        //    light.range = 0;
        //}

        //if (health.health <= health.max_Healt / 2)
        //{
        //    light.range = originalLightRange * 0.5f;
        //}
        //else
        //{
        //    light.range = originalLightRange;
        //}

        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject pointLightObj = new GameObject("Point Light");
            Light pointLight = pointLightObj.AddComponent<Light>();
            pointLight.type = LightType.Point;
            pointLight.range = 5;
            pointLight.intensity = 0.5f;
            pointLight.transform.position = transform.position + new Vector3(1, 0, 0);
            light.range *= 1f;
        }
    }


}
