using UnityEngine;
using System.Collections;

public class ReSet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerStatus.score = 0.0f;
		PlayerStatus.money = 0;
		PlayerStatus.remainHouse = 5;
		PlayerStatus.bonusCoin = 0;
		PlayerStatus.founded = false;
		PlayerStatus.hNum = 0;
		PlayerStatus.b_Array = new int[5];
		PlayerStatus.H_Array = new int[5];
		
		PlayerStatus.exitHouse = false;

		PlayerSoundEffect.foundOneShot = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
