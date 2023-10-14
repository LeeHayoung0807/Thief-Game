using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {

	public static float score = 0.0f;
	public static int money = 0;
	public static int remainHouse = 5;
	public static int bonusCoin = 0;
	public static bool founded = false;
	public static int hNum;
	public static int[] b_Array = new int[5];
	public static int[] H_Array = new int[5];

	public static bool exitHouse = false;

	public GUISkin skin;

	private static GameObject prevPos;

	private GUIStyle healthSkin;
	private GUIStyle moneySkin;
	private GUIStyle bonusSkin;
	private GUIStyle remainSkin;
	
	// Use this for initialization
	void Start () {
		healthSkin = skin.GetStyle ("Health");
		moneySkin = skin.GetStyle ("Money");
		bonusSkin = skin.GetStyle ("Bonus");
		remainSkin = skin.GetStyle("RemainHouse");
		if (exitHouse) {
			prevPos = GameObject.FindWithTag ("SetPlayerPrev");
			gameObject.transform.position = prevPos.GetComponent<PlayerPrevPos> ().getPrePos (hNum);
			exitHouse = false;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	void getScore(float i){
		score += i;
	}

	void getBonus(int idx){
		bonusCoin += 1;
		b_Array [idx] = 1;
	}

	void getMoney(){
		money += 1;
	}

	void giveMoney(int idx){
		if (money > 0 && H_Array [idx] == 0) {
			money -= 1;
			remainHouse -= 1;
			H_Array [idx] = 1;
		} 
		else if(money > 0) {
			money -= 1;
		}
	}

	void InToWater(){
		if (score > 0) {
			score -= 1;
		}
	}

	void OnGUI(){
		//GUI.skin = new GUISkin();
		Rect rect = new Rect(15,5,Screen.width/8,Screen.height/10);
		Rect rect2 = new Rect(15,60,Screen.width/8,Screen.height/10);
		Rect rect3 = new Rect(15,180,Screen.width/8,Screen.height/10);
		Rect rect4 = new Rect(15,120,Screen.width/8,Screen.height/10);
		GUI.Label(rect, "점수 : "+score.ToString(),healthSkin);
		GUI.Label(rect2,"복주머니 : "+money.ToString(),moneySkin);
		GUI.Label(rect3,"덕정동전 : "+bonusCoin.ToString(),bonusSkin);
		GUI.Label(rect4,"남은 집 : "+remainHouse.ToString(),remainSkin);
		//GUI.Label(rect, "체력 : "+health.ToString(),healthSkin);
		//GUI.Label(rect2,"복주머니 : "+money.ToString(),moneySkin);
		//GUI.Label(rect3,"덕정동전 : "+money.ToString(),bonusSkin);
	}


}
