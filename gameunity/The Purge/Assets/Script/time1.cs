using UnityEngine;
using System.Collections;

public class time1 : MonoBehaviour {
		
		//public float timeNow = 0f;
		//public float num = 0f;.

		private float gameTime = 0f;
	public GUIStyle myGUIStyle;

		//private float startTime = 0f;
		
		
		void Start(){
			//startTime = Time.deltaTime;
			gameTime = 60;
	
		}
		
		void Update(){

		if(gameTime ==0){
			Destroy(gameObject);
		}

		if(gameTime >= 1){
		 gameTime-=1*Time.deltaTime ;

		}else if((int)gameTime == 0){

			Application.LoadLevel("Win");
		}



	}
	void OnGUI(){

		GUI.Label (new Rect((Screen.width/4)+500,(Screen.height/24),300,300),"" + (int)gameTime ,myGUIStyle);

		//string timecl = ""+(int)gameTime;
		//GUI.Label(new Rect(100,100,200,20), ""+(int)gameTime);
		//GUI.Label(new Rect(100,100,1000,500),timecl);
		//Application.LoadLevel("Win");
		//if(gameTime == 0){
		//	Application.LoadLevel("Win");
		//}
		
	}
		
}
