using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	Animator anim;

	ParticleSystem shootingEffect;
	AudioSource injuredSound;
	AudioSource shootingSound;

	// Use this for initialization
	public bool isStarted;
	public bool shoot;

	void Start () {
		shoot = false;
		isStarted = false;
		//print("in player shooting start");
		anim = GetComponent<Animator>();
		shootingEffect = GetComponentInChildren<ParticleSystem> ();
		shootingSound = GetComponent<AudioSource> ();
		injuredSound = GetComponentInChildren<AudioSource> ();
//
	}
	
	// Update is called once per frame
	void Update () {
		if (shoot) {
			//print ("shoot");
			anim.SetTrigger ("shoot");
			shoot = false;
		} else
			;
	}

//	public void trigger(){
//		anim.SetTrigger ("shoot");
//	}
	public void Fire(){
		shootingSound.Play ();
		shootingEffect.Play ();
		injuredSound.Play ();
	}

	void initialComponent(){

	}


}
