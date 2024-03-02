using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public delegate void DeaathCallback();
    public event DeaathCallback onDeath;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public static GameManager GetInstance() { return instance; }
    public void IsDying()
    {
        onDeath?.Invoke();
    }
}
