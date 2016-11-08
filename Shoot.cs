using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody bulletcasing ;
	public int bulletspeed = 25;
	public float cadence = 0.5f;
	float cooldown = 0f;
	public int munition = 15;
	public int maxmun = 15;
	public int reserve = 50;
	public int maxreserve = 50;
	bool authorized = true;

	public bool Autho { get { return authorized; } set { authorized = value; } } 


	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > cooldown && authorized) {

			if (munition >0)

			{
				cooldown = Time.time + cadence;
		
	
				Rigidbody bullet;

				bullet = Instantiate (bulletcasing, transform.position, transform.rotation) as Rigidbody;
				munition -= 1;
				bullet.velocity = transform.TransformDirection (Vector3.forward * bulletspeed);
			
			}


		}


		if (Input.GetKeyDown ("r")) {

			reserve -= maxmun - munition;
			munition += maxmun - munition;

		}

	}


	void OnGUI() {
		GUI.Box (new Rect (Screen.width - 140, Screen.height -30, 130, 25), "Munition : " + munition + " / " + reserve);

	}
}
