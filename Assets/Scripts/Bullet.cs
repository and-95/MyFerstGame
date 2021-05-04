using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private GameObject shotSpawn;
    [SerializeField]
    private float timeDestroy;


    private float fireRate = 0.5f;

    private float nextFire = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire) // движение влево
        {
            nextFire = Time.time + fireRate;
            var a =  Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);
            Destroy(a, timeDestroy);
        }

        
        
            
        



    }
}
