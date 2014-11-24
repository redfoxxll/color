using UnityEngine;
using System.Collections;

public class StageLoop : MonoBehaviour {
	public float StageOffset;
	public Transform stage;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag != "StageLoop")
						return;

		Instantiate (stage, new Vector3 (other.transform.position.x, other.transform.position.y, other.transform.position.z + StageOffset),other.transform.rotation);
	}
}
