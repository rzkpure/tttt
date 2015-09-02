using UnityEngine;
using System.Collections;

public class SelectCha : MonoBehaviour {


	public Texture mybg;
	public Texture mytex1;
	public Texture mytex2;
	public Texture myBack;

	public GUIStyle customButtonMyCharacter1;
	public GUIStyle customButtonMyCharacter2;
	public GUIStyle customButtonMyBack;
	
	
	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);
		
		if(GUI.Button(new Rect(250,100,280,450), mytex1,customButtonMyCharacter1)) {
			Application.LoadLevel("PlayEasy1");
		}


		if(GUI.Button(new Rect(600,100,250,450), mytex2,customButtonMyCharacter2)) {
			Application.LoadLevel("PlayEasy2");
		}

		if(GUI.Button(new Rect(100,600,150,50), myBack,customButtonMyBack)) {
			Application.LoadLevel("UI");
		}
	}
	


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}




