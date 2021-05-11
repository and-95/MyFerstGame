using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health = 3;
    private GameObject obj;
    


    // Update is called once per frame
    void Update()
    {
        
        if (health == 0)
        {
            obj = GameObject.FindWithTag("Enemy");
            Destroy(obj);
        }
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.layer == 7)
        {
            health -= 1; 
            print("-1 HP :"+ health);
            Destroy(col.gameObject, 0f);

        }

    }
}
