using UnityEngine;
using System.Collections;

public class CollisionMonster : MonoBehaviour {
	public Score scor;
	public int hp = 3;
	public PlayerMoveMent set;
	void Update(){
		if(hp <= 0){
			scor.Scor += 100;
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
