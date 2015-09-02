using UnityEngine;
using System.Collections;

public class Lose : MonoBehaviour {


	
	public Texture myLose;
	public Texture myBack;
	public Texture myExit;

	public GUIStyle customButtonMyBack;
	public GUIStyle customButtonMyExit;
	
	//private float startTime = 0f;
	
	
	void Start(){
		//startTime = Time.deltaTime;
		//gameTime = 5;
		
	}
	
	void Update(){
		/*if(gameTime ==0){
			Destroy(gameObject);
		}

		if(gameTime >= 1){
			gameTime-=1*Time.deltaTime ;
			
		}else if(gameTime == 0){
			

		}
		
		*/
		
	}
	void OnGUI(){
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), myLose);
		//Application.LoadLevel("Win");
		if(GUI.Button(new Rect(100,550,150,50), myBack,customButtonMyBack)) {
			Application.LoadLevel("UI");
		}
		if(GUI.Button(new Rect(100,650,150,50), myExit,customButtonMyExit)) {
			Application.Quit();
		}
		
		
		
	}
}
