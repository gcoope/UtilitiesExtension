using UnityEngine;
using System.Collections;

public static class Utils {

	#region Maths

	#region Addition
	/// <summary>
	/// Adds a and b.
	/// </summary>
	/// <param name="a">The first int.</param>
	/// <param name="b">The second int.</param>
	public static int Add(int a, int b){
		return a + b;
	}
	/// <summary>
	/// Adds a and b.
	/// </summary>
	/// <param name="a">The first int.</param>
	/// <param name="b">The second int.</param>
	public static float Add(float a, float b){
		return a + b;
	}

	/// <summary>
	/// Adds all specified numbers.
	/// </summary>
	/// <param name="numbers">Numbers.</param>
	public static int Sum(params int[] numbers){
		int x = 0;
		for (int i = 0; i < numbers.Length; i++) {
			x += numbers[i];
		}
		return x;
	}
	/// <summary>
	/// Adds all specified numbers.
	/// </summary>
	/// <param name="numbers">Numbers.</param>
	public static float Sum(params float[] numbers){
		float x = 0;
		for (int i = 0; i < numbers.Length; i++) {
			x += numbers[i];
		}
		return x;
	}
	#endregion

	#region Subtraction
	/// <summary>
	/// Subtracts a from b.
	/// </summary>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static int Subtract(int a, int b){
		return a - b;
	}
	#endregion
	
	#region Multiplication
	/// <summary>
	/// Multiply a and b.
	/// </summary>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static int Multiply(int a, int b){
		return a * b;
	}
	/// <summary>
	/// Multiply a and b.
	/// </summary>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static float Multiply(float a, float b){
		return a * b;
	}

	/// <summary>
	/// Multiply the specified numbers.
	/// </summary>
	/// <param name="numbers">Numbers.</param>
	public static int Multiply(params int[] numbers){
		int x = 1;
		for (int i = 0; i < numbers.Length; i++) {
			x += x * numbers[i];
		}
		return x;
	}

	/// <summary>
	/// Multiply the specified numbers.
	/// </summary>
	/// <param name="numbers">Numbers.</param>
	public static float Multiply(params float[] numbers){
		float x = 1;
		for (int i = 0; i < numbers.Length; i++) {
			x += x * numbers[i];
		}
		return x;
	}

	/// <summary>
	/// Squares number.
	/// </summary>
	/// <param name="a">The value.</param>
	public static int Square(int a){
		return a * a;
	}
	/// <summary>
	/// Squares number.
	/// </summary>
	/// <param name="a">The value.</param>
	public static float Square(float a){
		return a * a;
	}

	/// <summary>
	/// Set a to the power of p.
	/// </summary>
	/// <param name="a">The value to power.</param>
	/// <param name="p">The power to which value will be increased by.</param>
	public static int Power(int a, int p){
		int x = 1;
		for (int i = 0; i < p; i++) {
			x = x * a;
		}
		return x;
	}
	/// <summary>
	/// Set a to the power of p.
	/// </summary>
	/// <param name="a">The value to power.</param>
	/// <param name="p">The power to which value will be increased by.</param>
	public static float Power(float a, float p){
		float x = 1;
		for (int i = 0; i < p; i++) {
			x = x * a;
		}
		return x;
	}
	#endregion

	#region division
	/// <summary>
	/// Divide a and b.
	/// </summary>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static int Divide(int a, int b){
		return a / b;
	}
	/// <summary>
	/// Divide a and b.
	/// </summary>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static float Divide(float a, float b){
		return a / b;
	}
	#endregion

	#region Percentages
	/// <summary>
	/// Find X percent of Y.
	/// </summary>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static float Percent(float a, float b){
		return (a / 100) * b;
	}

	/// <summary>
	/// Returns what percent X of Y is.
	/// </summary>
	/// <returns>The of.</returns>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static float PercentOf(float a, float b){
		return (a / b) * 100;
	}

	/// <summary>
	/// Perecentage increase from a to b.
	/// </summary>
	/// <returns>The increase.</returns>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static int PercentIncrease(int a, int b){
		return ((b - a) / a) * 100;
	}
	/// <summary>
	/// Perecentage increase from a to b.
	/// </summary>
	/// <returns>The increase.</returns>
	/// <param name="a">The first number.</param>
	/// <param name="b">The second number.</param>
	public static float PercentIncrease(float a, float b){
		return ((b - a) / a) * 100;
	}
	#endregion

	#endregion

	#region GameObjects

	#region Activating
	/// <summary>
	/// Enables the gameobject.
	/// </summary>
	/// <param name="g">The gameobject.</param>
	public static void EnableObject(GameObject g){
		g.SetActive (true);
	}
	/// <summary>
	/// Enables the transform's gameobject.
	/// </summary>
	/// <param name="g">The transform.</param>
	public static void EnableObject(Transform t){
		t.gameObject.SetActive (true);
	}
	/// <summary>
	/// Enables the collider's gameobject.
	/// </summary>
	/// <param name="g">The collider.</param>
	public static void EnableObject(Collider c){
		c.gameObject.SetActive (true);
	}
	/// <summary>
	/// Enables the gameobject.
	/// </summary>
	/// <param name="g">The gameobject's name.</param>
	public static void EnableObject(string obj){
		GameObject go = GameObject.Find (obj);
		if (go != null) {
			go.SetActive (true);
		} else {
			Debug.Log("Could not find object with name " + obj + " to enable");
		}
	}

	/// <summary>
	/// Enables all gameobjects by tag.
	/// </summary>
	/// <param name="tag">Tag.</param>
	public static void EnableAllTags(string tag){
		GameObject[] go = GameObject.FindGameObjectsWithTag (tag);
		if (go != null) {
			foreach (GameObject g in go) {
					g.SetActive (true);
			}
		} else {
			Debug.Log("Could not find any objects with tag " + tag + " to enable");
		}
	}
	#endregion

	#region Disactivating
	/// <summary>
	/// Disables the gameobject.
	/// </summary>
	/// <param name="g">The gameobject.</param>
	public static void DisableObject(GameObject g){
		g.SetActive (false);
	}
	/// <summary>
	/// Disables the transform's gameobject.
	/// </summary>
	/// <param name="g">The transform.</param>
	public static void DisableObject(Transform t){
		t.gameObject.SetActive (false);
	}
	/// <summary>
	/// Disables the collider's gameobject.
	/// </summary>
	/// <param name="g">The collider.</param>
	public static void DisableObject(Collider c){
		c.gameObject.SetActive (false);
	}
	/// <summary>
	/// Disables the gameobject.
	/// </summary>
	/// <param name="g">The gameobject's name.</param>
	public static void DisableObject(string obj){
		GameObject go = GameObject.Find (obj);
		if (go != null) {
			go.SetActive (false);
		} else {
			Debug.Log("Could not find object with name " + obj + " to enable");
		}
	}
	
	/// <summary>
	/// Disables all gameobjects by tag.
	/// </summary>
	/// <param name="tag">Tag.</param>
	public static void DisableAllTags(string tag){
		GameObject[] go = GameObject.FindGameObjectsWithTag (tag);
		if (go != null) {
			foreach (GameObject g in go) {
				g.SetActive (false);
			}
		} else {
			Debug.Log("Could not find any objects with tag " + tag + " to enable");
		}
	}
	#endregion

	#endregion
}