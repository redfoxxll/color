using UnityEngine;
using System.Collections;

public class BallDestroy : MonoBehaviour {
	public float delete1;
//	public AudioClip sound;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("DestroyDetect",5.0f,0.1f);
	}
	void DestroyDetect()
	{
		if(transform.position.z < Camera.main.transform.position.z||transform.position.y < delete1)
			GameObject.Destroy (transform.gameObject);
	}
//	void OnCollisionEnter(Collision collision）
//	                      {
//		audio.Play();
//	}
}