using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	

	public Texture mybg;
	public Texture namegame;
	public Texture myplay;
	public Texture myTutorial;
	public Texture myExit;
	public Texture myCredit;

	public GUIStyle customButtonMyPlay;
	public GUIStyle customButtonMyTutorial;
	public GUIStyle customButtonMyExit;
	public GUIStyle customButtonnamegame;
	public GUIStyle customButtonMyCredit;
	
	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);

		GUI.Label(new Rect(400,50,800,500), namegame,customButtonnamegame);
		
			
		
		if(GUI.Button(new Rect(100,100,200,80), myplay,customButtonMyPlay)) {
			Application.LoadLevel("SelectCharacter");
			
		}
		if(GUI.Button(new Rect(100,200,200,80), myCredit,customButtonMyCredit)) {
			Application.LoadLevel("Credit");
			
		}

		if(GUI.Button(new Rect(100,300,200,80), myTutorial,customButtonMyTutorial)) {
			Application.LoadLevel("Tutorial");
		}

		
		if(GUI.Button(new Rect(100,400,200,80), myExit,customButtonMyExit)) {
			Application.Quit();
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
