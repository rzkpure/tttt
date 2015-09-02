using UnityEngine;
using System.Collections;

public class DestroyTime : MonoBehaviour {

	public GameObject target;
	// Use this for initialization
	void Start () {
		Destroy(target,1f); //Destroy Bullet(target) 2vinatee
	}
}
