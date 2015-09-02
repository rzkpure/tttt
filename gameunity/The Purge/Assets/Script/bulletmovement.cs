using UnityEngine;
using System.Collections;

public class bulletmovement : MonoBehaviour {

	public float moveSpeed = 30f;
	public Transform bulletTran;
	void Start () {
		
	}
	
	void Update () {
		Vector3 moveVector = new Vector3(moveSpeed,0f,0f);
		bulletTran.position += (moveVector*Time.deltaTime);
	}
}
