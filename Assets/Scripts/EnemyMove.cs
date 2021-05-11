using UnityEngine;
using System.Collections;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]



public class EnemyMove : MonoBehaviour
{

	public int activeDistance = 10;
	public Transform[] wayPoints;
	public float stoppingDistance = 5;
	public float timeWait = 3;
	public float rotationSpeed = 5;
	public Transform defLook;
	private NavMeshAgent agent;
	private Vector3 target;
	private float curTimeout;
	private int wayCount;
	private bool isTarget;
	public static Transform player;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}



	void Update()
	{
		target = player.position;
		float dis = Vector3.Distance(transform.position, player.position);
		if (dis < activeDistance)
		{
			isTarget = true;
		}

		if (wayPoints.Length >= 2 && !isTarget)
		{
			agent.stoppingDistance = 2;
			agent.SetDestination(wayPoints[wayCount].position);
			if (!agent.hasPath)
			{

				curTimeout += Time.deltaTime;
				if (curTimeout > timeWait) { curTimeout = 0; if (wayCount < wayPoints.Length - 1) wayCount++; else wayCount = 0; }
			}
		}
		else if (wayPoints.Length == 0 || isTarget)
		{
			agent.stoppingDistance = stoppingDistance;
			agent.SetDestination(target);


		}
	}
}