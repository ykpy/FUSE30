using UnityEngine;
using System.Collections;

public class CherryGenerator : MonoBehaviour {

	public Timer timer;

	public float generateInterval;

	public GameObject cherry;

	// Use this for initialization
	void Start () {
		timer = FindObjectOfType<Timer>();
		StartCoroutine(GenerateCherry());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator GenerateCherry() {
		while (timer.firstTime > 0) {
			yield return new WaitForSeconds(generateInterval);
			Instantiate(cherry, new Vector3(Random.Range(-5.5f, 5.5f), Random.Range(9.0f, 12.0f), 0), Quaternion.identity);
		}
	}
}
