using UnityEngine;
using System.Collections;

public class BoxEffect : MonoBehaviour {

	public GameObject Effect = null;
	
	// Use this for initialization
	void Start () {
		Instantiate (Effect, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
