using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rb;
    public float _speed = 50f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward * _speed, ForceMode.Impulse);
    }
}
