using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour
{
    
    [SerializeField]
    private float _speed;
    private int enemHealh = 3;

    

    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "Enemy")
        {
            enemHealh -= 1;
            if (enemHealh == 0)
            {
                Destroy(col.gameObject, 0f); //удаляем врага с !КОТОРЫМ! столкнулись.
            }
            
        }

    }
}
