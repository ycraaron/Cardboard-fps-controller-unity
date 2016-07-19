using UnityEngine;
using System.Collections;

/// <summary>
/// Creates wandering behaviour for a CharacterController.
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class Wander : MonoBehaviour
{
	public float speed = 5;
	public float directionChangeInterval = 1;
	public float maxHeadingChange = 30;

	CharacterController controller;
	float heading;
	Vector3 targetRotation;

	public bool stopMoving = false;

	void Start ()
	{
		//print ("wander");

		stopMoving = false;

		controller = GetComponentInChildren<CharacterController>();

		// Set random initial rotation
		heading = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, heading, 0);

		StartCoroutine(NewHeading());
	}

	void Update ()
	{
	//	if (!stopMoving) {
	//		speed = 0.5f;
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
			var forward = transform.TransformDirection(Vector3.forward);
			controller.SimpleMove(forward * speed);
//		}	
//		else {
//			controller.SimpleMove(new Vector3(0,0,0));
//		}
	}

	/// <summary>
	/// Repeatedly calculates a new direction to move towards.
	/// Use this instead of MonoBehaviour.InvokeRepeating so that the interval can be changed at runtime.
	/// </summary>
	IEnumerator NewHeading ()
	{
		while (true) {
			NewHeadingRoutine();
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}

	/// <summary>
	/// Calculates a new direction to move towards.
	/// </summary>
	void NewHeadingRoutine ()
	{
		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
		var ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}

	public void stopPika(){
		stopMoving = true;
		speed = 0;
	}

	public void goPika(){
		stopMoving = false;
		speed = 0.12f;
	}
}