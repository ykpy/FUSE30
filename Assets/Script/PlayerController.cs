using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Score score;
    public Rigidbody2D move;

	// Use this for initialization
	void Start () {
		score = FindObjectOfType<Score>();
        move = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
    
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Item") {
			score.addscore();
			Destroy(col.gameObject);
			Debug.Log("Hit");
		}
	}
}
