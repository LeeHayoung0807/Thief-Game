using UnityEngine;
using System.Collections;

public class PlayerPrevPos : MonoBehaviour {
	
	public GameObject[] pPrevPos;
	public Vector3 playerPrevPosition;


	// Use this for initialization
	void Start () {
		pPrevPos = GameObject.FindGameObjectsWithTag ("PlayerPre");
		System.Array.Sort<GameObject>(pPrevPos, (x, y) => string.Compare(x.name, y.name));  
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector3 getPrePos(int i){
		return pPrevPos [i].transform.position;
	}
	
}
