using UnityEngine;
using System.Collections;

public class GiveMoney : MonoBehaviour {

	public int idx = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			other.transform.SendMessage("giveMoney",idx);
		}
	}
}
