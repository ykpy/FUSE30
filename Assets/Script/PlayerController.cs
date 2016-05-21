using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Score score;

	// Use this for initialization
	void Start () {
		score = FindObjectOfType<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Item") {
			score.addscore();
		}
	}
}
