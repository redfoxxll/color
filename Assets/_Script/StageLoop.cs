using UnityEngine;
using System.Collections;

public class StageLoop : MonoBehaviour {
	public float StageOffset;
	public Transform stage;
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("the collision "+other.tag);
		if (other.tag == "StageLoop")
			Instantiate (stage, new Vector3 (other.transform.position.x, other.transform.position.y, other.transform.position.z + StageOffset),other.transform.rotation);
		else if(other.tag == "gateblock")
			GameObject.Destroy (other.transform.parent.parent.parent.gameObject);
	}
}
