using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private int eHealth = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player" && PlayerStatus.founded) {
			Application.LoadLevel("badending");
		}
	}

	void damaged(int i){
		eHealth -= i;
	}
}
