using UnityEngine;
using System.Collections;

public class DeepWeb : MonoBehaviour {

	Shoot munition ;
	PlayerStat ps ;
	bool showgui = false ;
	bool mess = false;
	bool maintain = false;
	Move script;
	VueFps script2 ;
	
	void Start()
	{
		script = GetComponentInChildren<Move>();
		script2 = GetComponentInChildren<VueFps>();
		munition = GameObject.Find ("eject").GetComponent<Shoot> ();
		ps = GameObject.Find ("Play").GetComponent<PlayerStat> ();
	}
	
	void OnTriggerEnter (Collider hit) {
		
		if (hit.gameObject.tag == "Player") {
			
			showgui = true;
			mess = true;
			munition.Autho = false;
		}
		
		
		
	}
	
	void OnTriggerExit (Collider hit)
	{
		if (hit.gameObject.tag == "Player") {
			showgui = false ;
			mess = false ;
			munition.Autho = true;
		}
	}
	
	
	void OnGUI() {


		if (showgui) {
			if (mess)
			{
				GUI.Box(new Rect(Screen.width/2 - 100, Screen.height/2 - 12, 200,25),"Press I to buy in the Deep Web ") ;
			}
			if (Input.GetKeyDown (KeyCode.I)) {
				script.enabled = false;
				script2.enabled = false;
				mess = false;
				maintain = true;


			}
			
			if (maintain){
				
				if (GUI.Button (new Rect (40, 40, 130, 30), "MUNITION MAX : 10")) {
				
					if(ps.cash - 10 >=0) {
						munition.reserve += munition.maxreserve - munition.reserve;
						ps.cash -= 10;
					}

					mess = true;
					maintain = false;
					script.enabled = true;
					script2.enabled = true;


				}
				
				if (GUI.Button (new Rect (100, 100, 130, 30), "MINE MAX : 50")) {

					if(ps.cash - 50 >=0) {
						ps.mine += ps.MaxMine - ps.mine ;
						ps.cash -= 50 ;
					}
					mess = true ;
					maintain = false;
					script.enabled = true;
					script2.enabled = true;
				}
				
				
			}


		}
	}

}
