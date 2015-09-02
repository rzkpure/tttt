using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {

	public Texture myCredit;
	public Texture myBack;
	
	public GUIStyle customButtonMyBack;
	
	
	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), myCredit);
		
		
		if(GUI.Button(new Rect(100,600,150,50), myBack,customButtonMyBack)) {
			Application.LoadLevel("UI");
		}
	}

}
