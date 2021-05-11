using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private GameObject grenadeSpawn;
    [SerializeField]
    private float timeDestroy;
    private float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Update()
    {

        if (Input.GetKey(KeyCode.Q) && Time.time > nextFire) // движение влево
        {
            nextFire = Time.time + fireRate;
            var a = Instantiate(shot, grenadeSpawn.transform.position, grenadeSpawn.transform.rotation);
            Destroy(a, timeDestroy);
        }
    }
}
