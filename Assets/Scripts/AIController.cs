using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private float _distance;

    public int MoveSpeed = 4;

    private void Update()
    {
        _distance = Vector3.Distance(_player.position, transform.position);
        //print(_distance);

        if (_distance <= 4)
        {
            transform.LookAt(PlayerSingleton.Instance.transform);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
    }

}
