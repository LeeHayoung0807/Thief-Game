using UnityEngine;
using System.Collections;

public class GetBonus : MonoBehaviour {

	public int idx = 0;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			other.transform.SendMessage("getBonus",idx);
			Destroy (gameObject);
		}
	}
}
