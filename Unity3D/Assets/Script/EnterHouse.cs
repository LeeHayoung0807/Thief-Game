using UnityEngine;
using System.Collections;

public class EnterHouse : MonoBehaviour {

	public int houseNum = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.transform.tag == "Player") {
			switch (houseNum) {
			case 1:
				Application.LoadLevel ("house1_in2");
				PlayerStatus.hNum = 6;
				break;
			case 2:
				Application.LoadLevel ("house1_in1");
				PlayerStatus.hNum = 7;
				break;
			case 3:
				Application.LoadLevel ("house1_in3");
				PlayerStatus.hNum = 8;
				break;
			case 4:
				Application.LoadLevel ("house1_in4");
				PlayerStatus.hNum = 9;
				break;
			case 5:
				Application.LoadLevel ("house1_in5");
				PlayerStatus.hNum = 10;
				break;
			case 6:
				Application.LoadLevel ("house1_in6");
				PlayerStatus.hNum = 11;
				break;
			case 7:
				Application.LoadLevel ("house1_in7");
				PlayerStatus.hNum = 12;
				break;
			case 8:
				Application.LoadLevel ("house1_in8");
				PlayerStatus.hNum = 13;
				break;
			case 9:
				Application.LoadLevel ("house2_in");
				PlayerStatus.hNum = 0;
				break;
			case 10:
				Application.LoadLevel ("house2_in1");
				PlayerStatus.hNum = 1;
				break;
			case 11:
				Application.LoadLevel("house2_in2");
				PlayerStatus.hNum = 2;
				break;
			case 12:
				Application.LoadLevel("house2_in3");
				PlayerStatus.hNum = 3;
				break;
			case 13:
				Application.LoadLevel("house2_in4");
				PlayerStatus.hNum = 4;
				break;
			
			}
			
		}		
	}
}
