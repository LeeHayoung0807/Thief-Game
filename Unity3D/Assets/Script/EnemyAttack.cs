using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public GameObject Arrow;
	//public float ratePerSecond = 10.0f;
	private bool bShoot;

	// Use this for initialization
	void Start () {
		bShoot = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Shoot(){
		bShoot = true;
		StartCoroutine ("ShootArrows");

	}

	public void StopShoot(){
		if(bShoot){
			bShoot = false;
		}
		StopCoroutine ("ShootArrows");
	}

	private IEnumerator ShootArrows(){
		SpawnArrow ();
		yield return new WaitForSeconds(2.0f);
		StartCoroutine ("ShootArrows");
	}

	private void SpawnArrow(){
		Vector3 SpawnPos = transform.position;
		Quaternion SpawnRot = transform.rotation;
		SpawnRot = Quaternion.Euler(0, 180, 0);

		GameObject objArrow = (GameObject)Instantiate (Arrow, SpawnPos, SpawnRot);
	}
}
