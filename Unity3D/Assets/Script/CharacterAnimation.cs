using UnityEngine;
using System.Collections;

public class CharacterAnimation : MonoBehaviour {

	public float walkSpeed = 3.0f;
	private Vector3 prevPos;
	private float tolerable = 0.001f;

	bool IsWithinRange(Vector3 v1, Vector3 v2){
		if ((v1 - v2).sqrMagnitude < tolerable)
			return true;
		else
			return false;
	}

	// Use this for initialization
	void Start () {
		animation ["Walk"].speed = walkSpeed;
		prevPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!IsWithinRange (prevPos, transform.position))
			animation.CrossFade ("Walk", 0.1f);
		else
			animation.CrossFade ("Idle", 0.1f);

		prevPos = transform.position;
	}
}
