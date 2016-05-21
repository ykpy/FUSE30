using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int score = 0;
    public AudioSource bpm;
    public AudioClip sound;
    public Text scoreUI;

    public static Score instance;
    

	void Awake() {
	}

    void Start () {
        bpm = GetComponent<AudioSource>();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            addscore();
        }
    }
    public void addscore()
    {
        bpm.Stop();
        score += 10;
        
		bpm.PlayOneShot(sound);
        scoreUI.text = "score:" + score;
    }
      
}
