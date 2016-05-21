using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour {

    private Text mtext;
    private Score scoreP;
	// Use this for initialization
	void Start () {
        scoreP = GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
        string ScoreT = scoreP.score.ToString("000");
        mtext.text = "Score:" + ScoreT;
	}
}
