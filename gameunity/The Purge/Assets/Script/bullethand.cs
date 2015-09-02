using UnityEngine;
using System.Collections;

public class bullethand : MonoBehaviour {

	public GameObject bombParticle;
	
	void OnTriggerEnter(Collider otherCollider){
		if( otherCollider.CompareTag("mon1") ){
			otherCollider.gameObject.SendMessage("set_hp",1);
		}
	
	}
}
