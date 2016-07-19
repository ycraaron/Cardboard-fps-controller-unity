using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

	public AudioSource c_AudioSource;
	public AudioClip c_shootSound;   
	public bool gazeAt;
	public GameObject _gun;
	public PlayerShooting _shooting;
	int shoot_count;
	//Animator anim;
	//bool shooting;
	// Use this for initialization
	void Start () {
		print ("cube start()");
		_shooting = _gun.GetComponent<PlayerShooting>();
		c_AudioSource = GetComponent<AudioSource>();
		gazeAt = false;
		stareAt(gazeAt);
	}
	
	// Update is called once per frame
	void Update () {
//		if (gazeAt) {
//			//print ("Before fire");
//			_shooting.Fire ();
//			c_AudioSource.clip = c_shootSound;
//			c_AudioSource.Play();
//			//print ("After fire");
//		}
	}

//	void FixedUpdate(){
//				if (gazeAt) {
//					//print ("Before fire");
//					_shooting.Fire ();
//					c_AudioSource.clip = c_shootSound;
//					c_AudioSource.Play();
//					//print ("After fire");
//				}
//	}



	public void stareAt(bool gazeAt){
		GetComponent<Renderer>().material.color = gazeAt ? Color.green : Color.red;

		if (gazeAt) {
			//print ("Before fire");
			_shooting.Fire ();
			c_AudioSource.clip = c_shootSound;
			c_AudioSource.Play();
			//add enemy act


			//print ("After fire");
		}
	}

	public void gazeEnter(){
		gazeAt = true;
		stareAt (gazeAt);
	}

	public void gazeLeave(){
		gazeAt = false;
		stareAt (gazeAt);
	}
}
