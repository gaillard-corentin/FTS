
	// Use this for initialization
	using UnityEngine;
	using System.Collections;
	
	public class TransformFunctions : MonoBehaviour
	{
		public float moveSpeed = 10f;
		public float jumpspeed = 15f;
		public float turnSpeed = 50f;
		
		
		void Update ()
		{
			
			float h = Input.GetAxis ("Vertical"); 
			
			if(Input.GetKey(KeyCode.UpArrow))
				transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
			
			if(Input.GetKey(KeyCode.DownArrow))
				transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
			
			if(Input.GetKey(KeyCode.LeftArrow))
				transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
			
			if(Input.GetKey(KeyCode.RightArrow))
				transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		  	/*if (Input.GetKey (KeyCode.Space))
				transform.Translate (Vector3.up * jumpspeed * Time.deltaTime); */
				
				
				

		}
	}	
	
