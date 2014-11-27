using UnityEngine;
using System.Collections;

public class ButtonCallback : MonoBehaviour {

	public void PauseCallback()
	{
		//		Debug.Log ("the click");
		//		GameObject.Destroy (transform.parent.gameObject);
		//GameObject camera = GameObject.Find ("CameraMoveCarrier");
		//camera.transform.position = Vector3.zero;
		//camera.transform.FindChild ("Main Camera").GetComponent<Animator> ().SetTrigger("cameraenterscene");
		
		//TouchControl.ballmodecounter = 0;
		//TouchControl.shootingballmode = 1;
		//TouchControl.ballnumber = 5;
		//CameraMoveCarrier.distance = 0;
		
		//TouchControl.gameover = false;
		Application.LoadLevel (0);
	}
}