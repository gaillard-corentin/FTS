using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float moveSpeed = 10f;


	public float sensiX =20f;
	float minX = -180f;
	float maxX = 180f;
	
	float rotationX = 0f;



	public void Update () {
		
		rotationX = Mathf.Clamp (rotationX, minX, maxX);
		rotationX = Input.GetAxis ("MouseX") * sensiX; 
		transform.Rotate (0,rotationX, 0);


		if(Input.GetKey(KeyCode.Z))
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.Q))
			
			transform.Translate (-Vector3.right * moveSpeed * Time.deltaTime);
		
		if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		

	}
}
