using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySingleton : MonoBehaviour
{
    public static EnemySingleton Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
}