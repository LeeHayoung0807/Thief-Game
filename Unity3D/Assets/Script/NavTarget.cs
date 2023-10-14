using UnityEngine;
using System.Collections;

public class NavTarget : MonoBehaviour {

	private NavMeshAgent[] navAgents;
	public Transform targetMarker;
	private GameObject[] targetList;
	private Vector3 destPos;
	
	void Start ()
	{
		navAgents = FindObjectsOfType(typeof(NavMeshAgent)) as NavMeshAgent[];
		targetList = GameObject.FindGameObjectsWithTag ("Target");
		UpdateTargets ();
	}
	
	void UpdateTargets ()
	{
		foreach(NavMeshAgent agent in navAgents) 
		{	
			if(agent.transform.tag != "Enemy"){
				setTargets();
				agent.destination = destPos;
			}
		}
	}
	
	void Update ()
	{
		foreach(NavMeshAgent agent in navAgents) 
		{
			if(agent.transform.tag != "Enemy"){
				if(Vector3.Distance(agent.transform.position, agent.destination) < 1.0f){
					setTargets();
					agent.destination = destPos;
				}
			}

		}
	}

	void setTargets()
	{
		int rndindex = Random.Range (0, targetList.Length);
		destPos = targetList [rndindex].transform.position;

	}
}
