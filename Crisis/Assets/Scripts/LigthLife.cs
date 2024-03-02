using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthLife : MonoBehaviour
{
    private Health health;
    private new Light light;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        light.range*=health.GetlifeMax()/health.Getlife();
    }
}
