using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

	public float timerDuration = 1.0f;

	private float timerLook;

	private Button btnStart;
	private GameObject waitCanvas;

	private bool isLookAt;

	private GameObject gameController;
	private GameInitial initial;

	private Image img;

	// Use this for initialization
	void Start () {
		isLookAt = false;
		//waitCanvas = GameObject.Find("WaitCanvas");
		//btnStart = GameObject.Find("WaitCanvas").GetComponent<Button>();
		//gameController.GetComponent<
		waitCanvas = GameObject.Find ("WaitCanvas");
		gameController = GameObject.Find ("gameController");
		//btnStart.onClick.AddListener(() => SetGazeAt());

	}
	
	// Update is called once per frame
	void Update () {
		if (isLookAt) {
			//GetComponent<Image>().color = Color.gray;
			timerLook += Time.deltaTime;
			if (timerLook >= timerDuration) {
				//GetComponent<AudioSource> ().Stop ();
				isLookAt = false;
				timerLook = 0f;
				waitCanvas.SetActive (false);
				initial = (GameInitial) gameController.GetComponent(typeof(GameInitial));
				initial.StartScan ();
			}
		} else {
			timerLook = 0f;
			//GetComponent<Image> ().color = Color.white;
		}
	}

	public void SetGazeAt(){
		isLookAt = true;
		GetComponent<AudioSource> ().Play ();
		//print ("delegate");
	}
	public void SetGazeOff(){
		isLookAt = false;
		if (GetComponent<AudioSource> ().isPlaying) {
			GetComponent<AudioSource> ().Stop ();
		}

	}
		
}
