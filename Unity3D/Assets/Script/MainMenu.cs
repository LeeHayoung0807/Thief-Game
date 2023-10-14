using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUILayout.BeginArea(new Rect(Screen.width * 0.3f, Screen.height * 0.4f, Screen.width - (Screen.width * 0.6f), Screen.height - (Screen.height * 0.3f)));
		if(GUILayout.Button("게임시작"))
		{
			Application.LoadLevel("Main");
		}
		else if (GUILayout.Button("게임설명"))
		{
			Application.LoadLevel("GameExplain");
		}
		GUILayout.EndArea();
		
	}
}
