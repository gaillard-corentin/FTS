using UnityEngine;
using System.Collections;

public class VueFps : MonoBehaviour {

	public float sensiX =20f;
	public float sensiY = 20f;
	public float minX = -180f;
	public float maxX = 180f;
	public float minY = -180f;
	public float maxY = 180f;
	
	
	float rotationX = 0f;
	float rotationY = 0f;
	
	
	public Camera cam  ;
	
	// Update is called once per frame
	public void Update () {
		rotationX = Input.GetAxis ("MouseX") * sensiX; 
		rotationY = Input.GetAxis ("MouseY") * sensiY;
		rotationX = Mathf.Clamp (rotationX, minX, maxX);
		rotationY = Mathf.Clamp (rotationY, minY, maxY);			

		camera.transform.Rotate (-rotationY,0 ,0);
	}
}
