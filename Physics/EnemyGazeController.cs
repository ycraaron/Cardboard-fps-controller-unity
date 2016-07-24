using UnityEngine;
using System.Collections;

public class EnemyGazeController : MonoBehaviour {
	ParticleSystem explosion;
	AudioSource expsound;
	Animator anim;
	bool isShooted;
	int count;
	public GameObject gun;

	// Use this for initialization
	void Start () {
		explosion = GetComponentInChildren<ParticleSystem> ();
		expsound = GetComponentInChildren<AudioSource> ();
		anim = GetComponent<Animator> ();

		isShooted = false;
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
//		if (isShooted) {
//			if (count == 33 || count == 66 || count == 99) {
//				explosion.Play ();
//
//			} 
//			else if (count > 100)
//				Destroy (gameObject, explosion.duration);
//			else {
//				print (count);
//				count++;
//			}
//		}

		if (isShooted) {
			if (count == 100) {
				expsound.Play ();
				explosion.Play ();

				anim.SetBool ("isShooted", true);


				Destroy (gameObject, explosion.duration);

				count++;
			} else if (count > 100) {
				;
			} else {
				count++;
			}
		}
	}

	public void SetGazeIn(){
		isShooted = true;
//		explosion.Play ();
		//expsound.Play ();

		GetComponentInChildren<Renderer> ().material.color = Color.red;
//		expsound.Play ();
//		explosion.Play ();

//		anim.SetBool ("isShooted", true);
//		Destroy (gameObject, explosion.duration);
	}

	public void SetGazeOut(){
		isShooted = false;
		count = 0;

		GetComponentInChildren<Renderer> ().material.color = Color.white;
//		anim.SetBool("isShooted", false);
	}
}
