using UnityEngine;
using System.Collections;

public class EnemyTarget : MonoBehaviour {

	private NavMeshAgent agent;
	private GameObject[] targetList;
	private Vector3 destPos;
	private GameObject player;
	
	void Start ()
	{
		targetList = GameObject.FindGameObjectsWithTag ("Target");
		setTargets ();
	}

	void UpdateTarget(){
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		if (Vector3.Distance (agent.transform.position, destPos) < 1.0) {
			setTargets ();
			agent.destination = destPos;
		}
		else {
			agent.destination = destPos;
		}

	}

	void Update ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		if (PlayerStatus.founded && Vector3.Distance (agent.transform.position, player.transform.position) < 15.0) {
			agent.destination = player.transform.position;
		}
		else{
			UpdateTarget();
		}
		
	}

	void setTargets()
	{
		int rndindex = Random.Range (0, targetList.Length);
		destPos = targetList [rndindex].transform.position;
		
	}

}
