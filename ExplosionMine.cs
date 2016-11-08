using UnityEngine;
using System.Collections;

public class ExplosionMine : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	


	}
	

	void OnTriggerEnter (Collider hit) {
		
		if (hit.gameObject.tag == "Ennemy") {

			Destroy(gameObject);
		}
		
		
		
	}

}
