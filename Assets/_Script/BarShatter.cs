﻿//using UnityEngine;
//using System.Collections;

//public class BarShatter : MonoBehaviour {
//	void OnCollisionExit(Collision collision)
//	{
//		transform.rigidbody.useGravity = true;
//		transform.rigidbody.AddForce (new Vector3 (0, 0, 10), ForceMode.VelocityChange);
//		Debug.Log ("collision shatter");
//	}
//}



using UnityEngine;
using System.Collections;

public class BarShatter : MonoBehaviour {
	
	void Start () {
		//		InvokeRepeating ("Destroy",5.0f,0.5f);
	}
	void Destroy()
	{
		//		GameObject.Destroy (transform.gameObject);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		//		if (collision.transform.gameObject.layer == 8) 
		
		transform.rigidbody.useGravity = true;
		foreach (Transform child in transform) {
			rigidbody.useGravity = true;
			rigidbody.AddForce (new Vector3 (0, -5, 0), ForceMode.VelocityChange);
			Debug.Log ("with ball");
		}
		
	}
}
