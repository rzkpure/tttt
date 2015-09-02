using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public GUIStyle myGUIStyle;
	
	public int Scor;
	void Update(){

	}
	void OnGUI(){
		GUI.Label (new Rect((Screen.width/4)+10,(Screen.height/24),300,300),"" + Scor,myGUIStyle);
	}
	void setScore(int inScore){
		Scor = inScore;
	}
}
