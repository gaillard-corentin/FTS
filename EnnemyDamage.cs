using UnityEngine;
using System.Collections;

public class EnnemyDamage : MonoBehaviour {

	public int ennemyHealth = 100;
	PlayerStat ps ;

	void Start()
	{
		ps = GameObject.Find ("Play").GetComponent<PlayerStat> (); 
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			ennemyHealth -= 10;
		}

		if (col.gameObject.tag == "Mine") {
			ennemyHealth -=500;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (ennemyHealth <= 0) {
			ps.cash += 10;
			Destroy (gameObject);
		}
	}
}
