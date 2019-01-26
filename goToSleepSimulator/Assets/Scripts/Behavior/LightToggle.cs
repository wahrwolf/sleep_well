using UnityEngine;
public
class LightToggle : MonoBehaviour, ToDoInterface, WatchDogInterface
{
	Light light1;
	// Start is called before the first frame update
	void Start ()
	{
		light1	   = gameObject.GetComponentInChildren<Light> ();
		light1.intensity = 500;
	}
	// Update is called once per frame
	void Update ()
	{
	}
	public
	bool taskDone ()
	{
		return light1.intensity == 0;
	}
	public
	bool hasTriggered ()
	{
		return light1.intensity == 0;
	}
	private
	void OnTriggerEnter (Collider other)
	{
		if(!taskDone ()){
			Debug.Log ("Light Hit");
		}
		light1.intensity = 0;
	}
}