using UnityEngine;
using System.Collections;

public class HPController : MonoBehaviour {


	public int count = 0;
	public int collectAmount = 1;
	public bool isCollected = false; // can all keep if finish all , isCollected wll = true
	public float speed = 10;
	public moveBG setSpeed;
	
	
	void OnTriggerEnter(Collider Collidection){
		//if(isCollected){ return; }
		
		
		// code to keep will do ...
		if(Collidection.CompareTag("Boot")){
			count++;
			Collidection.gameObject.SetActive(false);
			if(count >= collectAmount){
				isCollected = true;

				//setSpeed.setSpeedBYBoot(speed);
				
				Destroy(Collidection.gameObject);
			}
			
			/*public int boot;
	//public TextMesh coinText;
	
	void OnTriggerEnter2D(Collider other){
		if(other.gameObject.tag == "Boot"){
			Destroy(other.gameObject);
			//coin += 1;


		}
	}
	
	void Update(){
		//coinText.text = coin;
		
	}*/
			
			
		}
	}
}
