using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GeorgeUtils;

/// <summary>
/// This is the class that will run first, setup application settings here.
/// This script must be attached to AppManager object
/// </summary>
public class StartApplcationCommand : MonoBehaviour {

	// Assign the starting context gameobject in the editor
	public GameObject StartingContext;

	void Awake() {
		if (StartingContext != null) {
			ContextManager.SetContext (StartingContext);
			showMessage ();
		} else {
			Debug.Log("<color=red>Unable to start. Have you assigned the starting context in AppManager?</color>");
		}
	}

	void showMessage(){
		Debug.Log ("<color=green>Started application " + Application.loadedLevelName + " using George's Framework v0.1</color>");
	}

}
