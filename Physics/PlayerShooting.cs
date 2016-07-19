using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	Animator anim;
	// Use this for initialization

	void Start () {
		print("in start");
		anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Fire(){
		anim.SetTrigger ("Fire");
	}

}
