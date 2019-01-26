using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public
class TvToggle : MonoBehaviour, ToDoInterface
{
	private
	GameObject plane;
	private
	bool done = false;
	// Start is called before the first frame update
	void Start ()
	{
		Transform tempPlane = transform.Find ("Screensaver");
		if (tempPlane != null) {
			plane = tempPlane.gameObject;
		} else {
			Debug.Log ("Could not load TV Plane!");
		}
	}
	// Update is called once per frame
	void Update ()
	{
	}
	public
	bool taskDone ()
	{
		return done;
	}
	private
	void OnTriggerEnter (Collider other)
	{
		if (!taskDone ()) {
			Debug.Log ("TV Hit");
		}
		done = true;
		plane.SetActive (false);
	}
}
