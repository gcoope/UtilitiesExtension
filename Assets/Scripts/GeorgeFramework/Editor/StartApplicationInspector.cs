using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(StartApplcationCommand))]
public class StartApplicationInspector : Editor {

	public override void OnInspectorGUI(){

		EditorGUILayout.LabelField("George's Framework v0.1", EditorStyles.boldLabel);

		base.OnInspectorGUI();
	}
}
