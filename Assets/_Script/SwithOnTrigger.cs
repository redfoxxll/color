using UnityEngine;
using System.Collections;

public class SwithOnTrigger : MonoBehaviour {
	public AudioClip sound;

	void Start () {
	
	}
	void OnTriggerEnter(Collider other){

		transform.GetComponent<Animator> ().SetBool ("SwithOnToOff",true);
		audio.Play();
	}
	void Update () {
	
	}
}
