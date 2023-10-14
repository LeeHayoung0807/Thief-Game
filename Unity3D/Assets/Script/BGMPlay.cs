using UnityEngine;
using System.Collections;

public class BGMPlay : MonoBehaviour {

	public AudioClip foundMusic = new AudioClip();
	public AudioClip backgroundMusic = new AudioClip();
	AudioSource AS;

	// Use this for initialization
	void Start () {
		AS = this.GetComponent<AudioSource>();
		if (PlayerStatus.founded) {
			AS.clip = foundMusic;
			AS.Play();
		}
		else {
			AS.clip = backgroundMusic;
			AS.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerStatus.founded) {
			musicPlay();
		}
	}

	void musicPlay(){
		if (AS.clip != foundMusic) {
			AS.Stop();
			AS.clip = foundMusic;
			AS.Play ();
		}
	}
}
