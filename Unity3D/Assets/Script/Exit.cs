using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			int ending = PlayerStatus.remainHouse;
			if(PlayerStatus.bonusCoin == 5){
				Application.LoadLevel("hiddenending");
			}
			else if(ending > 0){
				Application.LoadLevel("runending");
			}
			else{
				Application.LoadLevel("happyending");
			}
		}
	}
}
