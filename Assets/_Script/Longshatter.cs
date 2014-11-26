using UnityEngine;
using System.Collections;

public class Longshatter : MonoBehaviour {
	public Transform shatter1;
	public Transform shatter2;
	public Transform shatter3;
	public Transform shatter4;
	public Transform shatter5;
	public Transform shatter6;
	public Transform shatter7;
	public Transform shatter8;
	public Transform shatter9;
	public Transform shatter10;
	public Transform shatter11;
	public Transform shatter12;

	void OnCollisionEnter(Collision collision)
		//	void OnCollisionExit(Collision collision)
	{
		//			transform.rigidbody.useGravity = true;
		//		    foreach (Transform child in transform) {
		if (shatter1) 
		{
			shatter1.rigidbody.useGravity = true;
			shatter1.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		
		if (shatter2) 
		{
			shatter2.rigidbody.useGravity = true;
			shatter2.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		
		if (shatter3) 
		{
			shatter3.rigidbody.useGravity = true;
			shatter3.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		
		if (shatter4) 
		{
			shatter4.rigidbody.useGravity = true;
			shatter4.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		
		if (shatter5) 
		{
			shatter5.rigidbody.useGravity = true;
			shatter5.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		if (shatter6) 
		{
			shatter6.rigidbody.useGravity = true;
			shatter6.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		if (shatter7) 
		{
			shatter7.rigidbody.useGravity = true;
			shatter7.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		if (shatter8) 
		{
			shatter8.rigidbody.useGravity = true;
			shatter8.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		if (shatter9) 
		{
			shatter9.rigidbody.useGravity = true;
			shatter9.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		if (shatter10) 
		{
			shatter10.rigidbody.useGravity = true;
			shatter10.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		if (shatter11) 
		{
			shatter10.rigidbody.useGravity = true;
			shatter10.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}
		if (shatter12) 
		{
			shatter10.rigidbody.useGravity = true;
			shatter10.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);		
		}

		transform.rigidbody.useGravity = true;
		transform.rigidbody.AddForce (new Vector3 (0, -2, 1), ForceMode.VelocityChange);
		//		transform.GetComponent<FixedJoint> ().
		//		Debug.Log ("the joint is "+transform.GetComponent<SpringJoint> ().rigidbody.name);
		//		Debug.Log ("collision shatter");
		//			}
	}
	void OnJointBreak(float breakForce) {
		Debug.Log("A joint has just been broken!, force: " + breakForce);
	}
}
