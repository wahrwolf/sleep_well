using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public
class AlarmToggle : MonoBehaviour, ToDoInterface
{
	private
	GameObject alarmText;
	private
	bool done = false;
	// Start is called before the first frame update
	void Start ()
	{
		alarmText = GameObject.Find("AlarmText");
		alarmText.SetActive(false);
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
			Debug.Log ("Alarm Hit");
		}
		done = true;
		alarmText.SetActive (true);
	}
}
