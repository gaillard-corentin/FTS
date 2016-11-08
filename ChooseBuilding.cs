using UnityEngine;
using System.Collections;

public class ChooseBuilding : MonoBehaviour {
	public GameObject build1 ;
	public Vector3 spawnpos ;

	ViewCamera came ;
	PlayerStat ps ;
	bool mess = false;
	bool allow = true;


	public Color hovercolor;
	private Renderer rend;
	private Color Startcolor;

	void Start()
	{
		ps = GameObject.Find ("Play").GetComponent<PlayerStat> ();
		rend = GetComponent<Renderer>();
		Startcolor = rend.material.color;
		came = GameObject.Find ("Play").GetComponent<ViewCamera> ();

	}
	

	void OnMouseDown()
	{
		if (came.switchcamera == false) {
			mess = false;

			if (allow == false ) {
				return;
			}

			if (ps.cash - 25 >= 0){
				Instantiate (build1, transform.position + spawnpos, transform.rotation);
				allow = false;
			}
			
			rend.material.color = hovercolor;
		}


	}

	void OnMouseEnter()
	{
		if (came.switchcamera == false) {
			rend.material.color = hovercolor;
			mess = true;
		}
		
	}

	void OnMouseExit()
	{
		if (came.switchcamera == false) {
			rend.material.color = Startcolor;
			mess = false;
		}
	}

	void OnGUI() {

		if (mess)
		{
			GUI.Box(new Rect(Screen.width/2 - 100, Screen.height/2 - 12, 200,25),"Click to build") ;
		}
		/*if (showgui) {


			if (GUI.Button (new Rect (40, 40, 130, 30), "Tourelle")) {
				Instantiate (build1, transform.position + spawnpos, transform.rotation);
				allow = false;
				showgui = false ;
				mess = true;

					//script.enabled = true;
					//script2.enabled = true;
				}
				
			if (GUI.Button (new Rect (100, 100, 130, 30), "Build 2")) {
				Instantiate (build2, transform.position + spawnpos, transform.rotation);
				allow = false;
				showgui = false ;
				mess = true;
					//script.enabled = true;
					//script2.enabled = true;
				}

				
			}*/

		}
}





