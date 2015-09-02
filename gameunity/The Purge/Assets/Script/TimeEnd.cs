using UnityEngine;
using System.Collections;

public class TimeEnd : MonoBehaviour {



	public Texture myWin;
	public Texture myBack1;
	public Texture myExit;
	
	public GUIStyle customButtonMyBack1;
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

		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), myWin);
			//Application.LoadLevel("Win");
		if(GUI.Button(new Rect(100,550,150,50), myBack1,customButtonMyBack1)) {
			Application.LoadLevel("UI");
		}
		if(GUI.Button(new Rect(100,650,150,50), myExit,customButtonMyExit)) {
			Application.Quit();
		}
			
		

	
		
	}

}
