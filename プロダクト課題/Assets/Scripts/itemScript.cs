using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScript : MonoBehaviour {

	Rigidbody rig;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 1000);
		rig = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void FixedUpdate () {
		rig.velocity = new Vector3(0, 0, -2);

	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.SendMessage ("itemGet");
			Destroy (this.gameObject);
		}
	}
}