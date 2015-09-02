using UnityEngine;
using System.Collections;

public class MoveCha1 : MonoBehaviour {




	/*public Animator anim;
	private boolean checkwalk;
	private boolean checkJump;
	*/

	public float moveSpeed = 0.05f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
/*
		move();
		SetAnimation();
*/
		if(Input.GetKey("d")){
			transform.position += Vector3.forward * moveSpeed;
		}
		if(Input.GetKey("a")){
			transform.position -= Vector3.forward * moveSpeed;
		}


	}

	
	/*void move(){
		if(Input.GetKey("w")){
			tranform.Tranlate(0.5f,0,Time.deltaTime);
			checkJump = true;
			checkwalk = false;
		}else if(Input.GetKey("a")){
			tranform.Tranlate(-0.5f,0,Time.deltaTime);
			checkJump = true;
			checkwalk = false;
		}
		else{
			checkwalk = true;
			checkJump = false;
		}
	}

	void SetAnimation(){
		anim.SetBool("walk") checkwalk && !checkJump);
		anim.SetBool("jump") !checkwalk && checkJump);
	}*/
}




