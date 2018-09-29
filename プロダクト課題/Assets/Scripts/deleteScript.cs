using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteScript : MonoBehaviour {

	public GameObject wall,coin;
	private Transform pos;
	int coinCheck;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		
		Destroy (other.gameObject);
		if (other.gameObject.tag == "Score") {
			coinCheck = Random.Range (0, 3);
			transform.position = new Vector3 (0, Random.Range (-1, 2), 10);
			Instantiate (wall,transform.position,transform.rotation);

				
		}

	}
}
