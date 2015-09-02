using UnityEngine;
using System.Collections;

public class PlayerMoveMent : MonoBehaviour {



	public Animator anim;
	private bool checkwalk;
	private bool checkjump;
	public int hp = 3;



	void Update () {
		if (hp <= 0) {
			print("yourLose");
			Application.LoadLevel("Lose");
				}





		//playerMove();
		playerJump ();
		SetAnimation();

		//speed += 0.05f;
	}
	
	void playerJump(){
		if(Input.GetKey("w")){
			transform.Translate(0,8*Time.deltaTime,0);
		}
	
		else{
			checkwalk = true;
			checkjump = false;
		}
	}


	
	void SetAnimation(){
		anim.SetBool("walk", checkwalk && !checkjump);
		anim.SetBool("jump", !checkwalk && checkjump);
	}


	public void set_hp(int Hp)
	{
		hp -= Hp;
		}
	

}
