using UnityEngine;
using System.Collections;

public class GameInitial : MonoBehaviour {
	
	public Vector3 v3;
	public float speed;
	public GameObject vrFps;
	public Canvas waitCanvas;


	private CharacterController cc;
	private bool scan;
	private float stopPosition;
	private bool gameStart;

	private GameObject pokemonStatusBar;
	private GameObject gun;

	private Transform vrFpsTrans;


	// Use this for initialization
	void Start () {
		v3 = new Vector3 (0, 0);
		v3.z = 1;
		speed = 6.3f;

		stopPosition = vrFps.transform.position.z;

		vrFpsTrans = vrFps.transform;

		cc = vrFps.GetComponentsInChildren<CharacterController> ()[0];

		cc.enabled = false;


		pokemonStatusBar = GameObject.Find ("poke_status_bar");
		gun = GameObject.Find ("Gun");

		pokemonStatusBar.SetActive (false);
		gun.SetActive (false);

		gameStart = false;
		scan = true;
	
	}

	void InitialGame(){
		gameStart = true;
		//vrFpsTrans.position = new Vector3 (1.18f, 2.37f, 0.09f);
		//vrFps.transform.eulerAngles = new Vector3 (0, 270, 0);
		//cc.enabled = true;
		pokemonStatusBar.SetActive (true);
		gun.SetActive (true);
		scan = false;
	}

	void ShowWaitCanvas(){
	
	}
	// Update is called once per frame
	void Update () {
//		if (gameStart == false) {
//			stopPosition = vrFps.transform.position.z;
//			if (stopPosition > 42.0) {
//				InitialGame ();
//			}
//		}
//		if (scan == true) {
//			vrFps.transform.Translate(v3 * Time.deltaTime * speed, Space.World);
//
//		}
	}
}
