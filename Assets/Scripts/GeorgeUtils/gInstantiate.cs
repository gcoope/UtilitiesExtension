using UnityEngine;
using System.Collections;

namespace GeorgeUtils
{
	public class gInstantiate : MonoBehaviour {

		/// <summary>
		/// Creates an empty game object.
		/// </summary>
		/// <param name="name">Name.</param>
		public static void CreateEmptyGameObject(string name){
			GameObject g = new GameObject();
			g.name = name;
			g.transform.position = new Vector3(0,0,0);
		}

		/// <summary>
		/// Creates a cube.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="useRigidbody">If set to <c>true</c> use rigidbody.</param>
		public static void CreateCube(float x, float y, float z, bool useRigidbody){
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			if (useRigidbody) {
				cube.AddComponent<Rigidbody> ();
			}
			cube.transform.position = new Vector3(x, y, z);
		}

		/// <summary>
		/// Creates a sphere.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="useRigidbody">If set to <c>true</c> use rigidbody.</param>
		public static void CreateSphere(float x, float y, float z, bool useRigidbody){
			GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			if (useRigidbody) {
				sphere.AddComponent<Rigidbody> ();
			}
			sphere.transform.position = new Vector3(x, y, z);
		}

	}
}