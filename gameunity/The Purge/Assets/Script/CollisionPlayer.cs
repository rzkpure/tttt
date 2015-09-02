using UnityEngine;
using System.Collections;

public class CollisionPlayer : MonoBehaviour {
	
		
		/*public int count = 0;
		public int collectAmount = 3;
		public bool isCollected = false; // can all keep if finish all , isCollected wll = true
		
		

		
		
		void OnTriggerEnter(Collider otherCollider){
			if(isCollected){ return; }
			
			
			// code to keep will do ...
			if(otherCollider.CompareTag("mon1")){
				count++;
				otherCollider.gameObject.SetActive(false);
				if(count >= collectAmount){
					isCollected = true;
				}
			}
		}*/
	public int hp;
	public MonsterMove mon;
	public PlayerMoveMent player;
//	void OnCollisionEnter(Collision other) {
//		//player.speed -= player.speed;
//		if(other.gameObject.tag == "mon1" ){
//			set_hp(-1);
//			mon.moveSpeed = 0;
//		}
//	}
//	void OnCollisionStay(Collision other){
//		if(other.gameObject.tag == "mon1"){
//			mon.moveSpeed = 0;
//		}
//	}
//	void OnCollisionExit(Collision other){
//		//player.speed -= player.speed;
//		if(other.gameObject.tag == "mon1" ){
//			//mon.moveSpeed = 2f;er
//		}
//	}

	void set_hp(int inHp){
		hp -= inHp;
	}

	void Update(){
		if(hp <= 0){
			Destroy(gameObject);
		}
	}
	
}


