using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Snorlax_Save_Missing : MonoBehaviour {

	Animator anim;
	private GameObject infoCanvas;
	ParticleSystem collectionEffect;

	private bool is_captured;
	private float timerLook;
	private float start_time;

	//public int catchcount;
	public Text infotxt;

	// Use this for initialization
	void Start () {
		//catchcount = 0;
		anim = GetComponent<Animator> ();
		collectionEffect = GetComponentInChildren<ParticleSystem> ();
		is_captured = false;
		//infotxt = GameObject.Find ("InfoText");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//infoCanvas = GameObject.Find ("InfoCanvas");
		if (is_captured == true) {
			
			float delta_time = Time.time - start_time;
			if (delta_time > 2f && delta_time < 2.31f) {		
				anim.SetTrigger ("Jump");
				collectionEffect.Play ();
				//gameObject.SetActive (false);
			} else if (delta_time >= 3.11f) {
				gameObject.SetActive (false);	

			} else
				;
				

		}
	
	}

	public void setGazeAt(){
		infotxt.text = "   Capturing";
		start_time = Time.time;
//		anim.SetTrigger ("Jump");
//		collectionEffect.Play ();
//		infoCanvas.SetActive (true);
		is_captured = true;
		//gameObject.SetActive (false);
		//Destroy (gameObject, 0f);
//		while(true){
//			if (Time.time - start_time > 0.1f) {
//				is_captured = true;
//				break;
//			}
//		}

	}

	public void setGazeOff(){
		
		infotxt.text = "   Moving";
		//is_captured = false;

		//infoCanvas = GameObject.Find ("InfoCanvas");

		//infoCanvas.SetActive (false);
	}
}
