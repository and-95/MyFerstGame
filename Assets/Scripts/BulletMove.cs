using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour
{
    
    [SerializeField]
    private float _speed;
    
    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "Enemy")
        {  
                Destroy(col.gameObject, 0f); //удаляем врага с !КОТОРЫМ! столкнулись.
        }

    }
}
