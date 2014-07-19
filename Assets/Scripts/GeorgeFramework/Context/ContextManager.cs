using UnityEngine;
using System.Collections;
using GeorgeUtils;

public class ContextManager {

	private static GameObject currentContext;

	void Start () {
	
	}
	
	void Update () {
	
	}

	public static void SetContext(GameObject context){
		gGameObjects.DisableAllButThis (context);
		gGameObjects.EnableObject (context);
		SetCurrentContext (context);
	}

	public static void SetCurrentContext(GameObject c){
		currentContext = c;
	}

	public static GameObject GetCurrentContext(){
		return currentContext;
	}
}
