using UnityEngine;
using System.Collections;

public class ViewCamera : MonoBehaviour {

	public Camera Maincamera;
	public Camera TPScamera;
	bool switchcam = false;

	// Use this for initialization
	void Start () {
	
		Maincamera.camera.enabled= false;
		TPScamera.camera.enabled = true;



	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("e")) {
			switchcam = !switchcam;
								

			if (switchcam) {
				Maincamera.camera.enabled = true;
				TPScamera.camera.enabled = false;
			} else {
				Maincamera.camera.enabled = false;
				TPScamera.camera.enabled = true;


			}

		}


	}
}
