using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
    int score = 0;
	int highscore=0;
    private float speed = 2.0f;
    private Rigidbody rig;
	public Text highScoreText,scoreText;
	private string key="scorekey";
	public GameObject effect;
	public GameObject restartButton,resetButton;


	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
		highscore = PlayerPrefs.GetInt (key, 0);
		Physics.gravity = transform.up * -30;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		//rig.velocity = transform.right.normalized * 2.0f;

		if (Input.GetMouseButtonDown(0))
        {
            Gravity();
            //GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 0);
            // GetComponent<AudioSource>().Play();
        }
		if (score > highscore) {
			highscore = score;
			PlayerPrefs.SetInt (key, highscore);
		}
        
    }
   /* 
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("GameOver");
    }
    */
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Score")
        {
            score++;
			scoreText.text="Score:" + score;
        }

        if (coll.gameObject.tag == "barrier")
        {
            Debug.Log("GameOver");
			GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<BoxCollider> ().enabled = false;
			rig.isKinematic = true;
			highScoreText.text="High Score: "+highscore.ToString();
			highScoreText.gameObject.SetActive (true);
			effect.gameObject.SetActive (true);
			resetButton.gameObject.SetActive (true);
			restartButton.gameObject.SetActive (true);
			scoreText.gameObject.SetActive (false);
        }
    }
	void itemGet(){
		score+=10;
		scoreText.text="Score:" + score;
	}


    void Gravity()
    {
       // GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        Physics.gravity *=-1;
    }
}
