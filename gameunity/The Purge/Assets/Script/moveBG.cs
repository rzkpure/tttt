using UnityEngine;
using System.Collections;

public class moveBG : MonoBehaviour {
	public float speed = 5.0f;
	//public GameObject boot; 
	public bool timeCount = false;
	public float count = 5.0f;
	//public float speed = 5;
	// Use this for initialization
	void Start () {
		//boot.CompareTag("Boot");
	}
	
	// Update is called once per frame
	void Update () {
		playerMove();
		if (timeCount) {
			count-=1*Time.deltaTime;
		}
		if (count < 0) {
			speed = 5.0f;
		}
	}
	void playerMove(){
		
		transform.Translate(Vector3.right * Time.deltaTime * -speed);
	//	boot.transform.Translate(Vector3.right * Time.deltaTime * -speed);

		
	}
	public void setSpeedBYBoot(float inSpeed){
		speed = inSpeed;
		count = 5;
		timeCount = true;
	}
}
