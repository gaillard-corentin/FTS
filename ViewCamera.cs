using UnityEngine;
using System.Collections;

public class ViewCamera : MonoBehaviour {

	public Camera Maincamera;
	public Camera TPScamera;
	bool switchcam = false;
	VueFps vue ;
	Move mov ;
	Shoot shot ;

	public bool switchcamera { get { return switchcam; } set { switchcam = value; } }

	// Use this for initialization
	void Start () {
	
		vue = GetComponentInChildren<VueFps> ();
		mov = GetComponent<Move> ();
		shot = GameObject.Find ("eject").GetComponent<Shoot> ();
		Maincamera.camera.enabled= false;
		TPScamera.camera.enabled = true;
		vue.enabled = false;
		mov.enabled = false;
		shot.enabled = false;




	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("e")) {
			switchcam = !switchcam;
								

			if (switchcam) {
				Maincamera.camera.enabled = true;
				TPScamera.camera.enabled = false;
				vue.enabled = true;
				mov.enabled = true;
				shot.enabled = true;

			} else {
				Maincamera.camera.enabled = false;
				TPScamera.camera.enabled = true;
				vue.enabled = false;
				mov.enabled = false;
				shot.enabled = false;


			}

		}


	}
}
