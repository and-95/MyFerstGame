using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _health = 3;
    private GameObject _enemyObj;
 
    void Update()
    {
        
        if (_health == 0)
        {
            _enemyObj = EnemySingleton.Instance.gameObject;
            Destroy(_enemyObj);
        }
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.layer == 7)
        {
            _health -= 1; 
            print("-1 HP :"+ _health);
            Destroy(col.gameObject, 0f);

        }

    }
}
