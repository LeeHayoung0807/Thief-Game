using UnityEngine;
using System.Collections;

public class PlayerSoundEffect : MonoBehaviour {

	public AudioClip moneySE;
	public AudioClip giveSE;
	public AudioClip scoreSE;
	public AudioClip waterSE;
	public AudioClip bonusSE;
	public AudioClip foundSE;

	public static bool foundOneShot = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!foundOneShot && PlayerStatus.founded) {
			audio.PlayOneShot(foundSE);
			foundOneShot = true;
		}
	}

	void getScore(float i){
		audio.PlayOneShot (scoreSE);
	}
	
	void getBonus(int idx){
		audio.PlayOneShot (bonusSE);
	}
	
	void getMoney(){
		audio.PlayOneShot (moneySE);
	}
	
	void giveMoney(int idx){
		if (PlayerStatus.money > 0) {
			audio.PlayOneShot (giveSE);
		}
	}
	
	void InToWater(){
		audio.PlayOneShot (waterSE);
	}
}
