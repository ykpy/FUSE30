using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Score score;

    public Rigidbody2D move;

	Rigidbody2D rigidBody2D;
	public float movePower;
	public float moveSpeed;

	Vector2 moveDirection = Vector2.zero;


	// Use this for initialization
	void Start () {
		score = FindObjectOfType<Score>();
        move = GetComponent<Rigidbody2D>();
		rigidBody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection.x = Input.GetAxisRaw("Horizontal");
		moveDirection.y = Input.GetAxisRaw("Vertical");

		if (Mathf.Abs(moveDirection.x) > 0.5f) {
			rigidBody2D.AddForce(transform.up * movePower, ForceMode2D.Impulse);
		}
		transform.position += new Vector3(0, moveDirection.y, 0) * moveSpeed * Time.deltaTime;

	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Item") {
			score.addscore();
			Destroy(col.gameObject);
		}
	}
}
