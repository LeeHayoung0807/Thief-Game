using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	private GameObject[] playerPrevArray;
	private GameObject[] bonusArray;

	// Use this for initialization
	void Start () {
		playerPrevArray = GameObject.FindGameObjectsWithTag ("SetPlayerPrev");
		bonusArray = GameObject.FindGameObjectsWithTag ("Bonus");
		System.Array.Sort<GameObject>(bonusArray, (x, y) => string.Compare(x.name, y.name));
		if (playerPrevArray.Length > 1) {
			Destroy(playerPrevArray[1]);
		}
		for (int i = 0; i<5; i++) {
			if(PlayerStatus.b_Array[i] == 1)
				Destroy(bonusArray[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
