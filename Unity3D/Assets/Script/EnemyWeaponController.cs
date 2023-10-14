using UnityEngine;
using System.Collections;

public class EnemyWeaponController : MonoBehaviour {

	public EnemyAttack arrow;
	private GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (Vector3.Distance (transform.position, player.transform.position) < 10.0f) {
			ShootGun ();
		}
		else {
			StopShootGun ();
		}
	
	}

	public void ShootGun()
	{
		arrow.Shoot();
	}

	public void StopShootGun()
	{
		arrow.StopShoot();
	}
}
