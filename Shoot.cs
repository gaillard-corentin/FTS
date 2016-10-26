using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody bulletcasing ;
	public int bulletspeed = 25;
	public float cadence = 0.5f;
	float cooldown = 0f;
	bool mode = false;



	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > cooldown) {
			cooldown = Time.time + cadence;
		
	
			Rigidbody bullet;

			bullet = Instantiate (bulletcasing, transform.position, transform.rotation) as Rigidbody;

			bullet.velocity = transform.TransformDirection (Vector3.forward * bulletspeed);
		}


	}
}
