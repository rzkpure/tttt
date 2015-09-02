using UnityEngine;
using System.Collections;

public class CollisionMon2 : MonoBehaviour {


			
	public Score scor;
	public int hp = 2;
	public PlayerMoveMent set;
	void Update(){
		if(hp <= 0){
			scor.Scor += 50;
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		//print ("kuy");
		if(other.gameObject.CompareTag("Player")){
			set.set_hp(1);
		}
	}
	void set_hp(int inHp){
		hp -= inHp;
	}
	
	
	
	
	

}
