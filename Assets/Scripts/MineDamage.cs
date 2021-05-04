using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineDamage : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Enemy")
        { 
                Destroy(col.gameObject, 0f);

        }

    }
}
