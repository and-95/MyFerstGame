using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField]
    private float _speed;
    
    void Update()
    {
        //
         _rb = GetComponent<Rigidbody>();
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        // _rb.AddForce(transform.forward * _speed * Time.time, ForceMode.Force);
    }


}
