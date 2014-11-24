using UnityEngine;
using System.Collections;

public class BarShatter : MonoBehaviour {
	public Transform shatter1;
	public Transform shatter2;
	public Transform shatter3;
	public Transform shatter4;
	public Transform shatter5;

	void OnCollisionEnter(Collision collision)
//	void OnCollisionExit(Collision collision)
	{
//			transform.rigidbody.useGravity = true;
//		    foreach (Transform child in transform) {
		if (shatter1) 
		{
			shatter1.rigidbody.useGravity = true;
			shatter1.rigidbody.AddForce (new Vector3 (0, 0, 10), ForceMode.VelocityChange);		
		}

		if (shatter2) 
		{
			shatter2.rigidbody.useGravity = true;
			shatter2.rigidbody.AddForce (new Vector3 (0, 0, 10), ForceMode.VelocityChange);		
		}

		if (shatter3) 
		{
			shatter3.rigidbody.useGravity = true;
			shatter3.rigidbody.AddForce (new Vector3 (0, 0, 10), ForceMode.VelocityChange);		
		}

		if (shatter4) 
		{
			shatter4.rigidbody.useGravity = true;
			shatter4.rigidbody.AddForce (new Vector3 (0, 0, 10), ForceMode.VelocityChange);		
		}

		if (shatter5) 
		{
			shatter5.rigidbody.useGravity = true;
			shatter5.rigidbody.AddForce (new Vector3 (0, 0, 10), ForceMode.VelocityChange);		
		}
		transform.rigidbody.useGravity = true;
		transform.rigidbody.AddForce (new Vector3 (0, 0, 10), ForceMode.VelocityChange);
//		transform.GetComponent<FixedJoint> ().
//		Debug.Log ("the joint is "+transform.GetComponent<SpringJoint> ().rigidbody.name);
//		Debug.Log ("collision shatter");
//			}
	}
	void OnJointBreak(float breakForce) {
		Debug.Log("A joint has just been broken!, force: " + breakForce);
	}
}
