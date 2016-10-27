using UnityEngine;
using System.Collections;

public class BulletNone : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (3);
		Destroy (gameObject);
	}
	

}
