using UnityEngine;
using System.Collections;

public class ExitHouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			PlayerStatus.exitHouse = true;
			Application.LoadLevel("main");
		}
	}
}
