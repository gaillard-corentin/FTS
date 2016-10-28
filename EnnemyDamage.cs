using UnityEngine;
using System.Collections;

public class EnnemyDamage : MonoBehaviour {

	public int ennemyHealth = 100;


	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			ennemyHealth -= 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (ennemyHealth <= 0) {
			Destroy (gameObject);
		}
	}
}
