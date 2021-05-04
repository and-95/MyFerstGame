using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCreate : MonoBehaviour
{
    [SerializeField]
    private GameObject mine;
    [SerializeField]
    private GameObject mineSpawn;
    [SerializeField]
    private float timeDestroy;

    private float fireRate = 2.5f;

    private float nextFire = 0.0f;

    void Update()
    {
        if ((Input.GetKey(KeyCode.E) && Time.time > nextFire) ) // движение влево
        {
            nextFire = Time.time + fireRate;
            var a = Instantiate(mine, mineSpawn.transform.position, mineSpawn.transform.rotation);
            Destroy(a, timeDestroy);
        }
    }
}
