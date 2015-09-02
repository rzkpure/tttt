using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {



	public Texture mybg;
	public Texture mytex1;
	public Texture mytex2;
	
	
	//public GUIStyle customButtonMyCharacter1;
	//public GUIStyle customButtonMyCharacter2;

	
	static float timeNow;
	private float gameTime;
	private float startTime;
	
	
	
	void Start () {
		
		
		startTime = Time.deltaTime;
		
		gameTime = 0.5f;
		
		
	}

	
	void Update () {
		
		float num = startTime-Time.deltaTime;
		
		
		timeNow = gameTime+num;
		//guiText.text = ""+timeNow;

		
		if(timeNow==0.0f)
		{
			Application.LoadLevel("Win");
			
		}
		
	}

}
