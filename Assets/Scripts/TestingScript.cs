using UnityEngine;
using System.Collections;
using GeorgeUtils;

public class TestingScript : MonoBehaviour {

	void Start () {
		Debug.Log ("Add: " + GeorgeUtils.gMaths.Add (10, 20));
		Debug.Log (gMaths.Add (10, 12));
		Debug.Log(gPhysics.hasRigidbody("TaggedCube"));

		gInstantiate.Create3DTexT ("test 123 test 123 test 123 test 123 test 123", true, 12, new Vector3(10, 5, 1));
	}
}
