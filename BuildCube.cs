using UnityEngine;
using System.Collections;

public class BuildCube : MonoBehaviour {

	public Rigidbody building ;	
	public Vector3 spawnpos ;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.L)) {

			Rigidbody build ;

			build = Instantiate(building,transform.position + spawnpos, transform.rotation) as Rigidbody;


		}
	}
}
