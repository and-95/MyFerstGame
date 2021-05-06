using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDamage : MonoBehaviour
{
    public int enemyHealh = 3;
    private NavMeshAgent agent;
    public Transform _tr;

    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_tr.position);
       
    }

   

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
        }

        


        
       
    }

    
}
