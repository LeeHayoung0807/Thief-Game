using UnityEngine;
using System.Collections;

public class getScore : MonoBehaviour {

	public float point = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			other.transform.SendMessage("getScore",point);
			Destroy (gameObject);
		}
	}
}
