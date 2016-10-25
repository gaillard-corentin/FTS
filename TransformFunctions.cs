
	// Use this for initialization
	using UnityEngine;
	using System.Collections;
	
	public class TransformFunctions : MonoBehaviour
	{
		public float moveSpeed = 10f;
		
		public float turnSpeed = 50f;
		
		public float sensiX =20f;
		public float sensiY = 20f;
		public float minX = -180f;
		public float maxX = 180f;
		public float minY = -180f;
		public float maxY = 180f;


		float rotationX = 0f;
		float rotationY = 0f;



		Quaternion rotationplayer;
		Quaternion rotationcamera;

		public Camera cam  ;
		CharacterController charac ;

		Vector3 mov = Vector3.zero;

		void Start()
		{
		charac = gameObject.GetComponent<CharacterController>();
		rotationplayer = transform.localRotation;
		rotationcamera = cam.transform.localRotation;



		}

		void Update ()
		{
			//Rotationcamera
			rotationX = Input.GetAxis ("MouseX") * sensiX;
			rotationY = Input.GetAxis ("MouseY") * sensiY;
			rotationX = Mathf.Clamp (rotationX, minX, maxX);
			rotationY = Mathf.Clamp (rotationY, minY, maxY);
			Quaternion xrot = Quaternion.AngleAxis (rotationX, Vector3.up);
			Quaternion yrot = Quaternion.AngleAxis (rotationY, Vector3.right);
			transform.localRotation = rotationplayer * xrot;
			cam.transform.localRotation = rotationcamera * yrot;
			
			//Deplacement
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
	
