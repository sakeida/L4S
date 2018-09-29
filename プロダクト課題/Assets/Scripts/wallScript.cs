using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour {
    Rigidbody rig;
	int coinCheck;
	public GameObject coin;
    // Use this for initialization
    void Start () {
        Destroy(gameObject, 1000);
        rig = GetComponent<Rigidbody>();
		coinCheck = Random.Range (0, 3);
		if (coinCheck == 1) {
			Debug.Log ("DETA");
			Instantiate (coin, transform.position+new Vector3(0,Random.Range(-1f,2f),20),transform.rotation);
		}
        
    }

    // Update is called once per frame
    void FixedUpdate () {
        rig.velocity = new Vector3(0, 0, -2);

    }
}
