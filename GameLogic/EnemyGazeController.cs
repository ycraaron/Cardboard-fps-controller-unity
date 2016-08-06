using UnityEngine;
using System.Collections;

public class EnemyGazeController : MonoBehaviour {
	public ParticleSystem[] particleEffects;
	AudioSource[] soundEffects;
	public Animator anim;

	bool isStaredAt;
	int count;

	public GameObject gunObject;
	public PlayerShooting shootingController;

	private float start_time;
	private bool destroyed;
	// Use this for initialization
	void Start () {
		particleEffects = GetComponentsInChildren<ParticleSystem> ();
		soundEffects = GetComponents<AudioSource> ();
		anim = GetComponent<Animator> ();
		destroyed = false;
		isStaredAt = false;
		count = 0;
		gunObject = GameObject.Find ("Gun");
		//gunobject should be set in the inspector
		shootingController = gunObject.GetComponent<PlayerShooting>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		if (gameObject != null) {
			if (isStaredAt) {
				if (count == 1||count == 31||count == 61) {
					//call the fire function in gun
					if (count == 1 || count == 31) {
						anim.SetTrigger ("isShooted");//for enemy
						//shootingController.trigger();//gun anim
						shootingController.shoot = true;
						shootingController.Fire ();//for gun
						soundEffects [1].Play (22000);
					} else if (count == 61) {
						destroyed = true;
						shootingController.shoot = true;
						shootingController.Fire ();//for gun
						soundEffects[0].Play ();
						anim.SetTrigger ("isDying");
						start_time = Time.time;
//						particleEffects [0].Play ();
//						particleEffects [1].Play ();
					}
					count++;
				}
				else if (count > 100)
					;//do nothing
				else
					count++;
			}
			if (destroyed == true) {
				if(Time.time-start_time == 3.0f)
					gameObject.SetActive (false);
			}

		}


	}

	public void SetGazeIn(){
		if (!destroyed) {
			isStaredAt = true;
			GetComponentInChildren<Renderer> ().material.color = Color.red;
		}
		else
			isStaredAt = false;
//		shootingSound.Play ();
//		anim.SetBool ("isShooted", true);//Play the shooting status

//		if (isShooted)
//			isShooted = false;

//		Destroy (gameObject, explosion.duration);
	}

	public void SetGazeOut(){
		isStaredAt = false;
		count = 0;

		GetComponentInChildren<Renderer> ().material.color = Color.white;
//		anim.SetBool("isShooted", false);
	}
}
