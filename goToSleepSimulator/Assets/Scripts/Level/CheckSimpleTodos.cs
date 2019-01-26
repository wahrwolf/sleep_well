using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public
class CheckSimpleTodos : MonoBehaviour
{
	private
	bool _checkScore = true; 
	private
	GameObject scoreText;
	// Start is called before the first frame update
	void Start ()
	{
		// TODO: gather all conditions in list?
		// TODO: gather all todogadgets in list?
		
		scoreText = GameObject.Find("ScoreText");
		scoreText.SetActive(false);
	}
	// Update is called once per frame
	void Update ()
	{
		if (this._checkScore) {
			var exitConditions = FindObjectsOfType<MonoBehaviour> ().OfType<WatchDogInterface> ();
			bool alldone=true;
			foreach (WatchDogInterface watchdog in exitConditions) {
				MonoBehaviour item = (MonoBehaviour) watchdog;
				alldone &= watchdog.hasTriggered ();
			}
			if(alldone){
				Debug.Log ("Received End Condition! Will calculate Score now!");
				var possibleToDos = FindObjectsOfType<MonoBehaviour> ().OfType<ToDoInterface> ();
				var countall = 0;
				var countcorrect = 0;
				foreach (ToDoInterface todo in possibleToDos) {
					MonoBehaviour item = (MonoBehaviour) todo;
					Debug.Log ("Found todo: " + item.name +", your Score [" + todo.taskDone () + "]");
					countall++;
					if(todo.taskDone ()){
						countcorrect++;
					}
				}
				_checkScore=false;
				TextMesh t = scoreText.GetComponent<TextMesh>();
				t.text="Your Score "+countcorrect+"/"+countall;
				scoreText.SetActive(true);
			}
		}
	}
}
