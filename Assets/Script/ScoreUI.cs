using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour {

    private Text mtext;
    public string Nextscene;
	// Use this for initialization
	void Start () {
        
        mtext = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        int scoreP = Score.instance.score;
        string ScoreT = scoreP.ToString("000");
        mtext.text = "Score:" + ScoreT;
        if(Input.anyKeyDown)
        {
            Application.LoadLevel(Nextscene);
        }
	}
}
