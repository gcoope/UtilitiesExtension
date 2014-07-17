using UnityEngine;
using System.Collections;
using GeorgeUtils;

public class TestingScript : MonoBehaviour {

	void Start () {
		Debug.Log ("Add: " + GeorgeUtils.gMaths.Add (10, 20));
		Debug.Log (gMaths.Add (10, 12));
		Debug.Log(gPhysics.hasRigidbody("TaggedCube"));
	}
}
