using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerLogic : MonoBehaviour
{
    public GameObject obj;

        private void OnTriggerEnter(Collider other)
    {  
        Destroy(obj, 0f);
        print("Дверь Открыта!");
    }
}
