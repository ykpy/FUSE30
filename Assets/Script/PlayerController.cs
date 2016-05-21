using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Score score;
<<<<<<< HEAD
    public Rigidbody2D move;
=======
	Rigidbody2D rigidBody2D;
	public float movePower;
	public float moveSpeed;

	Vector2 moveDirection = Vector2.zero;
>>>>>>> 94f3fc03dd703888f4418ffd88604aad11aab8cd

	// Use this for initialization
	void Start () {
		score = FindObjectOfType<Score>();
<<<<<<< HEAD
        move = GetComponent<Rigidbody2D>();
=======
		rigidBody2D = GetComponent<Rigidbody2D>();
>>>>>>> 94f3fc03dd703888f4418ffd88604aad11aab8cd
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
    
=======
		moveDirection.x = Input.GetAxisRaw("Horizontal");
		moveDirection.y = Input.GetAxisRaw("Vertical");

		if (Mathf.Abs(moveDirection.x) > 0.5f) {
			rigidBody2D.AddForce(transform.up * movePower, ForceMode2D.Impulse);
		}
		transform.position += new Vector3(0, moveDirection.y, 0) * moveSpeed * Time.deltaTime;
>>>>>>> 94f3fc03dd703888f4418ffd88604aad11aab8cd
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Item") {
			score.addscore();
			Destroy(col.gameObject);
		}
	}
}
