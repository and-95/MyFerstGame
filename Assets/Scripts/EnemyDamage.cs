using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyHealh = 3;

    // Start is called before the first frame update
    

    // Update is called once per frame
    

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Bullet")
        {
            enemyHealh -= 1;
            //col.gameObject.name = "Enemy";
            if (enemyHealh == 0)
            {
                Destroy(col.gameObject, 0f);
            }
             //удаляем врага с !КОТОРЫМ! столкнулись.


        }

    }

    public void Damage()
    {
        enemyHealh -= 1;
    }
}
