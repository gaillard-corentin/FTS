using UnityEngine;
using System.Collections;

public class ThrowExplosive : MonoBehaviour {

	public Rigidbody MinePrefab ;
	public int speed = 3;
	PlayerStat ps ;
	// Use this for initialization
	void Start () {
		ps = GameObject.Find ("Play").GetComponent<PlayerStat> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (ps.mine > 0) {
			if (Input.GetKeyDown (KeyCode.M)) {
				Rigidbody instantMine;
				instantMine = Instantiate (MinePrefab, transform.position, transform.rotation)as Rigidbody;
				instantMine.velocity = transform.TransformDirection (Vector3.forward * speed);
				ps.mine -= 1;
			}
		}

	}
}
